﻿using System;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void beforeBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 wn = new Form4();
            wn.Show();
        }
    }
}
