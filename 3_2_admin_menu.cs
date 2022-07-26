using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C_Sharp
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 wn = new Form12();
            wn.Show();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 wn = new Form21();
            wn.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 wn = new Form11();
            wn.Show();
        }
    }
}
