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
    public partial class F1main : Form
    {
        public F1main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Base B = new Base();
            B.Owner = this;
            B.ShowDialog();
        }

        private void F1main_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            F2Way F2 = new F2Way();
            F2.Owner = this;
            F2.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
