using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using Renci.SshNet.Common;
using System.Security.Cryptography;

namespace prototype
{
    public partial class EditClientForm : Form
    {
        public EditClientForm(bool creating)
        {
            InitializeComponent();
            this.creating = creating;
            clientCB.Enabled = !creating;
            if (!creating) Program.db.FillClientCB(clientCB);
            Text = creating ? "Новый клиент" : "Редактирование данных о клиенте";
        }

        bool creating;

        private void EditClientForm_Load(object sender, EventArgs e)
        {
        }
        void insertClient()
        {
            
        }
        private void saveClientButton_Click(object sender, EventArgs e)
        {
            if (creating)
            {
                bool success = Program.db.CreateClient(this);
                MessageBox.Show(success ? "Клиент добавлен" : "Ошибка добавления");
            }
            else
            {
                bool success = Program.db.EditClient(this);
                MessageBox.Show(success ? "Данные о клиенте обновлены" : "Ошибка обновления");
            }
        }

        private void EditClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void clientCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
