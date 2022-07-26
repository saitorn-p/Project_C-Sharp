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
    public partial class Form22 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn; 
        }

        public Form22()
        {
            InitializeComponent();
        }

        private void showall()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pre_order";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();

            dataorder.DataSource = ds.Tables[0].DefaultView;

            dataorder.Columns[4].Visible = false;
            dataorder.Columns[5].Visible = false;
            dataorder.Columns[6].Visible = false;
            dataorder.Columns[7].Visible = false;
            dataorder.Columns[8].Visible = false;
            dataorder.Columns[9].Visible = false;
            dataorder.Columns[10].Visible = false;

            dataorder.Columns[0].Width = 80;
            dataorder.Columns[1].Width = 200;
            dataorder.Columns[2].Width = 400; 
            dataorder.Columns[3].Width = 140; 
        }

        private void showorder()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet(); 
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pre_order WHERE phone_number = '" + phone.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();

            dataorder.DataSource = ds.Tables[0].DefaultView;

            dataorder.Columns[4].Visible = false;
            dataorder.Columns[5].Visible = false;
            dataorder.Columns[6].Visible = false;
            dataorder.Columns[7].Visible = false;
            dataorder.Columns[8].Visible = false;
            dataorder.Columns[9].Visible = false;
            dataorder.Columns[10].Visible = false;
            dataorder.Columns[11].Visible = false;

            dataorder.Columns[0].Width = 80; 
            dataorder.Columns[1].Width = 200; 
            dataorder.Columns[2].Width = 400; 
            dataorder.Columns[3].Width = 140; 
        }

        private void dataorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbname.Text = dataorder.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbaddress.Text = dataorder.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbphone.Text = dataorder.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            showorder();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            showall();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            showall();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataorder.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataorder.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "UPDATE pre_order SET name = '" + tbname.Text + "', address = '" + tbaddress.Text + "', phone_number = '" + tbphone.Text + "' WHERE phone_number = '" + this.tbphone.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                showall();
            }            
        }
    }
}
