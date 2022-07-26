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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e) 
        {
            this.Hide(); 
            Form2 wn = new Form2();
            wn.Show();
        }

        private void sellerBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form12 wn = new Form12();
            wn.Show();
        }
    }
}
