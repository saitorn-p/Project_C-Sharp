using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_C_Sharp
{
    public partial class Form23 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form23()
        {
            InitializeComponent();
        }

        public string name; 
        public string address;
        public string phone;
        public string date;
        public string type;
        public string color;
        public string pin;

        private void Form23_Load(object sender, EventArgs e)
        {
            lbname.Text = name;
            lbaddress.Text = address;
            lbphone.Text = phone;
            lbdate.Text = date;
            lbtype.Text = type;
            lbcolor.Text = color;
            lbpin.Text = pin;

            lbmoney.Text = "395";
            lbmoney1.Text = "0";
            lbmoney2.Text = "395";
        }
    }
}
