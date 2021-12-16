using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovik
{
    public partial class F3choose : Form
    {
        public string CommandText = "SELECT * FROM [Расписание]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Kursovik\\Kursovik\\Database1.accdb";

        public void My_Execute_Non(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();

        }
        public F3choose()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                if (textBox1.Text == "636" || textBox1.Text == "204" || textBox1.Text == "309")
                {
                    F4BuyTicket F4 = new F4BuyTicket();
                    F4.Owner = this;

                    F5Check F5 = new F5Check();
                    F5.Owner = this;
                    Base B = new Base();
                    /* bool flag = false;
                     for (int i = 0; i < listBox1.Items.Count; i++)
                     {
                         for (int j = 0; j < B.dataGridView1.RowCount; j++)
                         {
                             string nn = B.dataGridView1.Rows[j].Cells.ToString();
                             if (B.dataGridView1.Rows[j].Cells[1].Value != null)
                                 if (B.dataGridView1.Rows[j].Cells.ToString().Equals(listBox1.Items[i]))
                                 {
                                     if (B.dataGridView1.Rows[j].Cells[0].Value.ToString().Equals(textBox1.Text))
                                     {
                                         flag = true;
                                         break;
                                     }
                                 }
                         }
                     }*/


                    for (int i = 0; i < B.dataGridView1.RowCount; i++)
                    {
                        if (B.dataGridView1.Rows[i].Cells[0].Value != null)
                            if (B.dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(textBox1.Text))
                            {
                                F5.label3.Text += B.dataGridView1.Rows[i].Cells[8].Value.ToString();//cумма
                                F5.label4.Text += B.dataGridView1.Rows[i].Cells[0].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[1].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[2].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[3].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[4].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[5].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[6].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[7].Value.ToString()
                                             + " " + B.dataGridView1.Rows[i].Cells[8].Value.ToString(); //маршрут

                            }
                    }

                    F4.ShowDialog();


                    F5.label1.Text += F4.textBox1.Text + "  " + F4.textBox3.Text + "  " + F4.textBox2.Text;
                    F5.label2.Text += F4.textBox7.Text;




                    //внесем в базу что билет продан

                    double n = Convert.ToDouble(textBox1.Text);
                    for (int i = 0; i < B.dataGridView1.RowCount; i++)
                    {
                        if (B.dataGridView1.Rows[i].Cells[0].Value != null)
                            if (B.dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(textBox1.Text))
                            {
                                string n1 = B.dataGridView1.Rows[i].Cells[1].Value.ToString();
                                string n2 = B.dataGridView1.Rows[i].Cells[2].Value.ToString();
                                string n3 = B.dataGridView1.Rows[i].Cells[3].Value.ToString();
                                string n4 = B.dataGridView1.Rows[i].Cells[4].Value.ToString();
                                string n5 = B.dataGridView1.Rows[i].Cells[5].Value.ToString();
                                string n6 = B.dataGridView1.Rows[i].Cells[6].Value.ToString();
                                string n8 = B.dataGridView1.Rows[i].Cells[8].Value.ToString();
                                double n7 = Convert.ToDouble(B.dataGridView1.Rows[i].Cells[7].Value.ToString());

                                //удаление строки
                                string ID = Convert.ToString(B.dataGridView1[0, i].Value);
                                string ComText1 = "DELETE FROM [Расписание] WHERE [Расписание].[Номер рейса] = " + ID;
                                My_Execute_Non(ComText1);
                                OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                                DataSet dse = new DataSet();
                                dAd.Fill(dse, "[Расписание]");
                                B.dataGridView1.DataSource = dse.Tables["[Расписание]"].DefaultView;
                                B.dataGridView1.Refresh();

                                //в базу внести
                                double kolvo = n7 - 1;
                                int nrow = B.dataGridView1.Rows.Count - 2; //Номер последней строки
                                int r = Convert.ToInt16(B.dataGridView1.Rows[nrow].Cells[0].Value.ToString()) + 1;
                                string ComText2 = "INSERT INTO [Расписание] ([Номер рейса], [Откуда], [Куда], [Дата вылета]," +
                                    " [Время вылета], [Дата прилета],[Время прилета], [Количество мест], [Стоимоть])"
                               + "VALUES ('" + n + "', '" + n1 + "', '" + n2 + "', '" + n3 + "', '"
                               + n4 + "', '" + n5 + "', '" + n6 + "', '" + kolvo + "', '" + n8 + "')";

                                My_Execute_Non(ComText2);

                                OleDbDataAdapter dA = new OleDbDataAdapter(CommandText, ConnString);
                                DataSet ds = new DataSet();
                                dA.Fill(ds, "[Расписание]");
                                B.dataGridView1.DataSource = ds.Tables["[Расписание]"].DefaultView;
                                B.dataGridView1.Refresh();

                            }

                    }

                    F5.ShowDialog();
                }
                else { DialogResult dr = MessageBox.Show("Данного рейса не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }


            }
            else
            {
                DialogResult dr = MessageBox.Show("Введите номер рейса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }

        }
    }
}
