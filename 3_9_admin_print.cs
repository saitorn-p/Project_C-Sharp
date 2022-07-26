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
    public partial class Form24 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn; 
        }

        public Form24()
        {
            InitializeComponent();
        }

        private void dataorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbname.Text = dataorder.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbaddress.Text = dataorder.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbphone.Text = dataorder.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbtype.Text = dataorder.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbcolor.Text = dataorder.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbpin.Text = dataorder.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbdate.Text = dataorder.Rows[e.RowIndex].Cells[11].Value.ToString();

                tbname.Enabled = false;
                tbaddress.Enabled = false;
                tbphone.Enabled = false;
                tbtype.Enabled = false;
                tbcolor.Enabled = false;
                tbpin.Enabled = false;
                tbdate.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("มีความผิดพลาด", "Message");
            }
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 wn = new Form11();
            wn.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open(); 
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pre_order WHERE product_number = '" + pd_number.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd); 
            adapter.Fill(ds);
            conn.Close();

            dataorder.DataSource = ds.Tables[0].DefaultView;

            dataorder.Columns[7].Visible = false;
            dataorder.Columns[8].Visible = false;
            dataorder.Columns[9].Visible = false;
            dataorder.Columns[10].Visible = false;

            dataorder.Columns[0].Width = 80;
            dataorder.Columns[1].Width = 200;
            dataorder.Columns[2].Width = 500; 
            dataorder.Columns[3].Width = 140; 
            dataorder.Columns[4].Width = 120; 
            dataorder.Columns[5].Width = 140; 
            dataorder.Columns[6].Width = 140;
            dataorder.Columns[11].Width = 200;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pre_order WHERE payment_status = \"ชำระเงินเรียบร้อยแล้ว\"";
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
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            Form23 f = new Form23();
            f.name = tbname.Text;
            f.address = tbaddress.Text;
            f.phone = tbphone.Text;
            f.type = tbtype.Text;
            f.color = tbcolor.Text;
            f.pin = tbpin.Text;
            f.date = tbdate.Text;
            f.ShowDialog();
        }
    }
}
