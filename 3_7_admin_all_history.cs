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
    public partial class Form21 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form21()
        {
            InitializeComponent();
        }

        int number;

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "")
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM pre_order WHERE date = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();

                dataorder.DataSource = ds.Tables[0].DefaultView;

                dataorder.Columns[0].Width = 80; 
                dataorder.Columns[1].Width = 200; 
                dataorder.Columns[2].Width = 500; 
                dataorder.Columns[3].Width = 140; 
                dataorder.Columns[4].Width = 120; 
                dataorder.Columns[5].Width = 140; 
                dataorder.Columns[6].Width = 140; 
                dataorder.Columns[7].Width = 200; 
                dataorder.Columns[8].Width = 200;
                dataorder.Columns[9].Width = 200;
                dataorder.Columns[10].Width = 200; 
                dataorder.Columns[11].Width = 200;

                string sql = $"SELECT * FROM pre_order WHERE date = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' ";
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;");
                cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    number++;
                }

                lbTotal.Text = number.ToString();
                number = 0;

                if (lbTotal.Text != "")
                {
                    int total = Convert.ToInt32(lbTotal.Text);
                    int last_money = total * 395;
                    lbMoney.Text = last_money.ToString();
                }
            }

        }

        private void Form21_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 wn = new Form20();
            wn.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pre_order";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            string sql = "SELECT * FROM pre_order";
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;");
            cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                number++;
            }

            lbTotal.Text = number.ToString();
            number = 0;

            if (lbTotal.Text != "")
            {
                int total = Convert.ToInt32(lbTotal.Text);
                int last_money = total * 395;
                lbMoney.Text = last_money.ToString();
            }

            conn.Close();

            dataorder.DataSource = ds.Tables[0].DefaultView;


            dataorder.Columns[0].Width = 80; 
            dataorder.Columns[1].Width = 200; 
            dataorder.Columns[2].Width = 500; 
            dataorder.Columns[3].Width = 140; 
            dataorder.Columns[4].Width = 120; 
            dataorder.Columns[5].Width = 140; 
            dataorder.Columns[6].Width = 140; 
            dataorder.Columns[7].Width = 200; 
            dataorder.Columns[8].Width = 200;
            dataorder.Columns[9].Width = 200;
            dataorder.Columns[10].Width = 200; 
            dataorder.Columns[11].Width = 200;
        }
    }
}
