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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pre_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 wn = new Form5(); 
            wn.Show();
        }

        private void check_status_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 wn = new Form14();
            wn.Show();
        }

        private void howtoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 wn = new Form16();
            wn.Show();
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 wn = new Form2(); 
            wn.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
