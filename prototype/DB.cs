using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using Renci.SshNet.Common;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace prototype
{

    class DB
    {
        private MySqlConnection connection;
        private ForwardedPortLocal port;

        private int employeeId;
        private string employeeName;

        public DB()
        {
            Connect();
        }

        private void Connect()
        {
            if (connection != null && connection.State == ConnectionState.Open) return;
            #region Подключение по SSH
            if (port == null || !port.IsStarted)
            {
                // сервер, порт, логин, пароль
                PasswordConnectionInfo connectionInfo = new PasswordConnectionInfo("free9.beget.com", 22, "h982945m", "56QLYf5C");
                connectionInfo.Timeout = TimeSpan.FromSeconds(30);
                SshClient client = new SshClient(connectionInfo);
                client.Connect();
                // проброс порта
                port = new ForwardedPortLocal("127.0.0.1", 3307, "127.0.0.1", 3306);
                client.AddForwardedPort(port);
                port.Start();
            }
            #endregion
            #region Собственно, подключение к БД
            try
            {
                MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
                connBuilder.Server = "127.0.0.1";
                connBuilder.Port = 3307;
                connBuilder.UserID = "h982945m_sectech";
                connBuilder.Password = "n6&uX99*";
                connBuilder.Database = "h982945m_sectech";
                //string connStr = "SERVER=127.0.0.1;PORT=3307;UID=h982945m_sectech;PASSWORD=n6&uX99*;DATABASE=h982945m_sectech";
                connection = new MySqlConnection(connBuilder.ConnectionString);
                connection.Open();
            }
            catch { }
            #endregion
        }

        public DataSet GetDataSet(string query)
        {
            DataSet result = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = new MySqlCommand(query, connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                da.Fill(result);
            }
            catch { }
            return result;
        }

        public string Login(string login, string password)
        {
            this.Connect();
            string hash = this.CalculateMD5Hash(password);
            string query = string.Format(@"SELECT `employee_id`, `employee_name` FROM `h982945m_sectech`.`employee`
                WHERE `employee_login` = '{0}' AND `employee_pass` = '{1}'", login, hash);
            try
            {
                DataSet ds = GetDataSet(query);
                this.employeeId = Convert.ToInt32(ds.Tables[0].Rows[0]["employee_id"]);
                this.employeeName = ds.Tables[0].Rows[0]["employee_name"].ToString();
                return this.employeeName;
            }
            catch
            {
                return "";
            }
        }

        public bool CreateClient(EditClientForm form)
        {
            this.Connect();
            string dateBirthSQL = form.clientBirthdayDTP.Value.ToString("yyyy-MM-dd");
            string passDateSQL = form.clientIssueDateDTP.Value.ToString("yyyy-MM-dd");

            MySqlDataAdapter da = new MySqlDataAdapter();
            string query = String.Format(@"INSERT INTO `h982945m_sectech`.`client`(`client_name`, `client_passport_no`,
                `client_passport_issue_date`, `client_passport_issue_department`, `client_birthdate`,`client_male`) 
                VALUES ('{0}','{1}','{2}','{3}','{4}',{5});", form.clientNameTB.Text, form.clientPassportIdTextbox.Text,
                passDateSQL, form.clientPassportIssueDepartmentTB.Text, dateBirthSQL, form.maleRB.Checked ? 1 : 0);

            MySqlCommand sqlCom = new MySqlCommand(query, connection);
            try
            {
                sqlCom.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditClient(EditClientForm form)
        {
            this.Connect();
            string dateBirthSQL = form.clientBirthdayDTP.Value.ToString("yyyy-MM-dd");
            string passDateSQL = form.clientIssueDateDTP.Value.ToString("yyyy-MM-dd");

            MySqlDataAdapter da = new MySqlDataAdapter();
            string query = String.Format(@"UPDATE `h982945m_sectech`.`client` SET `client_name` = '{0}',
                `client_passport_no` = '{1}', `client_passport_issue_date` = '{2}',
                `client_passport_issue_department` = '{3}', `client_birthdate` = '{4}', `client_male` = {5}
                WHERE `client_id` = {6};",
                form.clientNameTB.Text, form.clientPassportIdTextbox.Text, passDateSQL,
                form.clientPassportIssueDepartmentTB.Text, dateBirthSQL, form.maleRB.Checked ? 1 : 0, form.clientCB.SelectedValue);
            MySqlCommand sqlCom = new MySqlCommand(query, connection);
            try
            {
                sqlCom.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SetOrder(OperatorForm form)
        {

            this.Connect();
            DateTime dd= form.dateTimePicker1.Value;
            switch (form.comboBox4.SelectedIndex)
            {
                case 0:
                    dd.AddMonths(3);
                    break;
                case 1:
                     dd.AddMonths(6);
                    break;
                case 2:
                     dd.AddMonths(12);
                    break;
            }
            
            MySqlDataAdapter da = new MySqlDataAdapter();
            string query = String.Format(@" INSERT INTO `h982945m_sectech`.`document` (`document_date`,
                `fk_client_id`, `fk_employee_id`, `document_expire_date`, `document_price`) VALUES
                ('{0}',{1},{2},'{3}',{4});",
               form.dateTimePicker1.Value.ToString("yyyy-MM-dd"),form.comboBox1.SelectedValue, employeeId,
               dd.ToString("yyyy-MM-dd"), form.price.ToString().Replace(',', '.'));
            MySqlCommand sqlCom = new MySqlCommand(query, connection);
            try
            {
                sqlCom.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void FillClientData(EditClientForm form)
        {
        }

        public void FillClientCB(ComboBox clientCB)
        {
            string query = "SELECT * FROM `h982945m_sectech`.`client`";
            this.FillComboBox(clientCB, query, "client_id", "client_name");
        }

        private void FillComboBox(ComboBox cb, string query, string valueMember, string displayMember)
        {
            cb.Items.Clear();
            DataSet ds = GetDataSet(query);
            cb.DataSource = ds.Tables[0];
            cb.ValueMember = valueMember;
            cb.DisplayMember = displayMember;
        }

        private string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }

        ~DB()
        {
            try
            {
                connection.Close();
                port.Stop();
            }
            catch { }
        }
    }
}
