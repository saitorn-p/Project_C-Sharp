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
    public partial class Form14 : Form
    {
        private MySqlConnection databaseConnection() 
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void showorder1()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet(); 
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pre_order WHERE product_number = '" + tbproduct_number.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();

            dataorder.DataSource = ds.Tables[0].DefaultView;

            dataorder.Columns[0].Visible = false;
            dataorder.Columns[9].Visible = false;
            dataorder.Columns[11].Visible = false;

            dataorder.Columns[1].Width = 200; 
            dataorder.Columns[2].Width = 400; 
            dataorder.Columns[3].Width = 140; 
            dataorder.Columns[4].Width = 120;
            dataorder.Columns[5].Width = 140; 
            dataorder.Columns[6].Width = 140; 
            dataorder.Columns[7].Width = 200; 
            dataorder.Columns[8].Width = 200;
            dataorder.Columns[10].Width = 200; 
            
        }

        public Form14()
        {
            InitializeComponent();
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 wn = new Form4();
            wn.Show();
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            showorder1();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}