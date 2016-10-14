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
    public partial class OperatorForm : Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        public double price;
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.db.FillClientCB(comboBox1);
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 2;
            textBox17.Text = "18";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EditClientForm(true).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox3.SelectedIndex == 0)
            {
                price = 5650;
                switch (comboBox4.SelectedIndex)//период срахования
                {
                    case 0:
                        price *= 0.6;
                        break;
                    case 1:
                        price *= 0.7;
                        break;
                    case 2:
                        price *= 1;
                        break;
                }
                if ((int)numericUpDown1.Value > 3)//стаж водителя
                {
                    price *= 1;
                }
                else
                {
                    price *= 1.6;
                }

                if ((int)numericUpDown2.Value > 1)//количество водителей
                {
                    price *= 1;
                }
                else
                {
                    if (((int)numericUpDown2.Value) == 0)
                        price *= 1.8;
                    else
                        price *= 1.2;
                }
                if (Convert.ToInt32(textBox17.Text) > 22)//возраст водителя
                {
                    price *= 1;
                }
                else
                {
                    price *= 1.6;
                }
            }
            else
            {
                price = 3320;
                switch (comboBox4.SelectedIndex)//Семейное положение
                {
                    case 0:
                        price *= 1.5;
                        break;
                    case 1:
                        price *= 1.5;
                        break;
                    case 2:
                        price *= 1;
                        break;
                }
                switch (comboBox4.SelectedIndex)//Дети
                {
                    case 0:
                        price *= 1.2;
                        break;
                    case 1:
                        price *= 1;
                        break;
                }
                switch (comboBox4.SelectedIndex)//Франшиза
                {
                    case 0:
                        price *= 1.8;
                        break;
                    case 1:
                        price *= 1.7;
                        break;
                    case 2:
                        price *= 1.6;
                        break;
                    case 3:
                        price *= 1.4;
                        break;
                }
                switch (comboBox4.SelectedIndex)//Противоугонное устройство
                {
                    case 0:
                        price *= 0.9;
                        break;
                    case 1:
                        price *= 1.2;
                        break;
                }
                switch (comboBox4.SelectedIndex)//Период страхования
                {
                    case 0:
                        price *= 0.6;
                        break;
                    case 1:
                        price *= 0.7;
                        break;
                    case 2:
                        price *= 1;
                        break;
                }
                if ((int)numericUpDown1.Value > 3)//стаж водителя
                {
                    price *= 1;
                }
                else
                {
                    price *= 1.6;
                }

                if ((int)numericUpDown2.Value > 1)//количество водителей
                {
                    price *= 1;
                }
                else
                {
                    if (((int)numericUpDown2.Value) == 0)
                        price *= 1.8;
                    else
                        price *= 1.2;
                }
                if (Convert.ToInt32(textBox17.Text) > 22)//возраст водителя
                {
                    price *= 1;
                }
                else
                {
                    price *= 1.6;
                }
            }
            string priceSt = String.Format(" {0:0.00}", price);
            MessageBox.Show((comboBox3.SelectedIndex == 0 ? "Ваша стоимость ОСАГО составляет:" : "Ваша стоимость КАСКО составляет:") + priceSt, "Стоимость");
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            bool success = Program.db.SetOrder(this);
            MessageBox.Show(success ? "Заявка оформлена" : "Ошибка оформления");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EditClientForm(false).ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                comboBox2.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;
                comboBox7.Enabled = true;
            }
        }
    }
}
