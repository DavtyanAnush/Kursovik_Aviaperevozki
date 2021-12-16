using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik
{
    public partial class F4BuyTicket : Form
    {
        public F4BuyTicket()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && comboBox1.Text != "")
            {
                Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Пожалуйста, Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((n <= 47 || n >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((n <= 47 || n >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;
        }
    }
}