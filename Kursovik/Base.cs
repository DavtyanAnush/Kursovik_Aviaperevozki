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
    public partial class Base : Form
    {
        //Подключение базы данных
        public string CommandText = "SELECT * FROM [Расписание]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Kursovik\\Kursovik\\Database1.accdb";

      
        public Base()
        {
            InitializeComponent();

            OleDbDataAdapter dA = new OleDbDataAdapter(CommandText, ConnString);
            DataSet ds = new DataSet();
            //Заполняем таблицу
            dA.Fill(ds, "[Расписание]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void Base_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.database1DataSet.Расписание);
                       
        }
    }
}
