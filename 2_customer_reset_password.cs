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
    public partial class Form15 : Form
    {
        private MySqlConnection databaseConnection() 
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void showreset(string sql)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds); 
            conn.Close(); 

            datacustomer_login.DataSource = ds.Tables[0].DefaultView;

            datacustomer_login.Columns[2].Visible = false;

            datacustomer_login.Columns[1].Width = 140; 

        }
        public Form15()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM customer_login WHERE phone_number = '" + phone.Text + "' AND user = '" + user.Text + "'";
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                showreset($"SELECT * FROM customer_login WHERE phone_number = '{phone.Text}' AND user = '{user.Text}'");
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบข้อมูลให้ถูกต้อง", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 wn = new Form2(); 
            wn.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            string pass = password.Text;
            string pass1 = password1.Text; 

            if(pass == pass1)
            {
                int selectedRow = datacustomer_login.CurrentCell.RowIndex;
                int editId = Convert.ToInt32(datacustomer_login.Rows[selectedRow].Cells["ID"].Value);

                MySqlConnection conn1 = databaseConnection();
                string sql = "UPDATE customer_login SET password = '" + password.Text + "'WHERE ID = '" + editId + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                conn1.Open();
                int rows = cmd.ExecuteNonQuery();
                conn1.Close();

                if (rows > 0)
                {
                    MessageBox.Show("เปลี่ยนรหัสผ่านสำเร็จ","Message");
                    this.Hide();
                    Form2 wn = new Form2();
                    wn.Show();
                }
                
            }
            else
                {
                    MessageBox.Show("กรุณาป้อนรหัสผ่านให้ถูกต้อง", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
    }
}
