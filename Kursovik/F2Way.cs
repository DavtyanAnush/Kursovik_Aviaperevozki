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
    public partial class F2Way : Form
    {
        public F2Way()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            F3choose F3 = new F3choose();
            F3.Owner = this;
            Base B = new Base();
            bool flag = true;
            if (comboBox1.Text != "Откуда" && comboBox2.Text != "Куда")
            {
                // int index = -1;
                for (int i = 0; i < B.dataGridView1.RowCount; i++)
                {

                    if (B.dataGridView1.Rows[i].Cells[1].Value != null)
                        if (B.dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(comboBox1.Text))
                        {
                            string r = dateTimePicker1.Value.ToString("dd.MM.yyyy") + " 0:00:00";
                            string r1 = B.dataGridView1.Rows[i].Cells[3].Value.ToString();
                            
                            if (B.dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(comboBox2.Text))
                                if (r1 == r)
                                {
                                    flag = false;
                                    F3.listBox1.Items.Add(B.dataGridView1.Rows[i].Cells[0].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[1].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[2].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[3].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[4].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[5].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[6].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[7].Value.ToString()
                                     + " " + B.dataGridView1.Rows[i].Cells[8].Value.ToString());

                                }
                        }


                }

                if (flag) { DialogResult dr = MessageBox.Show("Данного маршрута не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {

                    F3.ShowDialog();

                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Не все данные введены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
