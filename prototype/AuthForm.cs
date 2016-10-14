using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Program.db.Login(login.Text, pass.Text);

            if (name == "")
            {
                MessageBox.Show("Неправильный логин/пароль");
            }
            else
            {
                MessageBox.Show("Здравствуйте, " + name);
                this.Hide();
                new OperatorForm().Show();
                return;
            }
        }
    }
}

