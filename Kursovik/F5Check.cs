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
    public partial class F5Check : Form
    {
        public F5Check()
        {
            InitializeComponent();

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Билет напечатан!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
