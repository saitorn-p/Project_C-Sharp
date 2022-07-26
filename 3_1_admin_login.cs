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
    public partial class Form12 : Form
    {
        private MySqlConnection databaseConnection() 
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form12()
        {
            InitializeComponent();
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wn = new Form1();
            wn.Show();
        }

        private void loginBnt_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM admin_login WHERE username = '" + username.Text + "' AND password = '" + password.Text + "'";
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.Hide();
                Form20 wn = new Form20();
                wn.Show();
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบข้อมูลให้ถูกต้อง", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password.Checked)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }
    }
}
