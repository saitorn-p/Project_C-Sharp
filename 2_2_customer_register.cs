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
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn; 
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void signinBnt_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            string p = password.Text;
            int num_pass = p.Length;

            if (num_pass < 8 && num_pass > 20)
            {
                MessageBox.Show("โปรดตั้งรหัสผ่านที่ความยาว 8-20 ตัว", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string pass = password.Text;
                string pass1 = password1.Text;
 
                if (pass == pass1)
                {
                    String sql = "INSERT INTO customer_login (phone_number, password, user) VALUES('" + phone.Text + "','" + password.Text + "','" + user.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
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

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 wn = new Form2(); 
            wn.Show();
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Text != "") 
            {
                int number;
                if (!Int32.TryParse(phone.Text, out number))
                {
                    MessageBox.Show("ป้อนหมายเลขโทรศัพท์ให้ถูกต้อง", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    phone.Focus(); 
                }

                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM customer_login WHERE phone_number = '{phone.Text}'";
                MySqlDataReader row = cmd.ExecuteReader();
                
                if (row.HasRows)   
                {
                    conn.Close(); 
                    MessageBox.Show("เบอร์โทรศัพท์ซ้ำ", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phone.Focus(); 
                }
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password.Checked)
            {
                password.UseSystemPasswordChar = true;
                password1.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
                password1.UseSystemPasswordChar = false;
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM customer_login WHERE user = '{user.Text}'";
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                conn.Close(); 
                MessageBox.Show("Uer ซ้ำ", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone.Focus();
            }
        }
    }
}
