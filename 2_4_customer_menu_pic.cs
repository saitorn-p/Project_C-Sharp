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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 wn = new Form4(); 
            wn.Show();
        }

        private void detail1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 wn = new Form6(); 
            wn.Show();
        }


        private void detail2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 wn = new Form7();
            wn.Show();
        }

        private void detail3Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 wn = new Form8();
            wn.Show();
        }

        private void pre_orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 wn = new Form9();
            wn.Show();
        }
    }
}
