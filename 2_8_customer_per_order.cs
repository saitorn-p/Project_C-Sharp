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
    public partial class Form9 : Form
    {
        private MySqlConnection databaseConnection() 
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                return conn; 
            }

        public Form9()
        {
            InitializeComponent();
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
            string name = this.tbname.Text;
            int n = name.Length;

            if (n < 1)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbaddress_TextChanged(object sender, EventArgs e)
        {
            string name = this.tbaddress.Text;
            int a = name.Length;

            if (a <1)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            }
        }

        private void pin_TextChanged(object sender, EventArgs e)
        {
            string p = pin.Text;
            int num_pin = p.Length;

            if (num_pin > 20)
            {
                MessageBox.Show("ข้อมูลของคุณยาวเกินไป", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 wn = new Form5(); 
            wn.Show();
        }


        private void confirmBtn_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            
            string name1 = this.tbname.Text;
            int n = name1.Length;

            string adderss = this.tbaddress.Text;
            int a = adderss.Length;

            string phone_nunber = phone.Text;
            int ph = phone_nunber.Length;

            string c = comboBox1.Text;
            int num_type = c.Length;

            if (n < 1 && ph != 10 && a < 1 && num_type < 1 )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (color1.Checked)
                {
                    Random random = new Random();
                    int random_number = random.Next();

                    MySqlConnection conn1 = databaseConnection();
                    conn.Open();
                    MySqlCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM pre_order WHERE product_number = '{random_number}'";
                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        conn.Close();
                        MessageBox.Show("มีข้อผิดพลาด", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //phone.Focus();
                    }
                    else
                    {
                        String sql1 = "INSERT INTO pre_order (name, address, phone_number, type, color, pin, payment_status, product_status, product_number, date) VALUES('" + tbname.Text + "','" + tbaddress.Text + "','" + phone.Text + "','" + comboBox1.Text + " ','" + "สีดำ" + "','" + pin.Text + "','" + "กำลังดำเนินการ" + "','" + "กำลังดำเนินการ" + "','" + random_number + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                        conn.Open();
                        int rows = cmd1.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show(random_number.ToString(), "กรุณาจดจำเลขติดตามสินค้า", MessageBoxButtons.OK);

                            this.Hide();
                            Form10 wn = new Form10();
                            wn.Show();
                        }
                    }
                }
                else if (color2.Checked)
                {
                    Random random = new Random();
                    int random_number = random.Next();

                    MySqlConnection conn1 = databaseConnection();
                    conn.Open();
                    MySqlCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM pre_order WHERE product_number = '{random_number}'";
                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        conn.Close();
                        MessageBox.Show("มีข้อผิดพลาด", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //phone.Focus();
                    }
                    else
                    {
                        String sql1 = "INSERT INTO pre_order (name, address, phone_number, type, color, pin, payment_status, product_status, product_number, date) VALUES('" + tbname.Text + "','" + tbaddress.Text + "','" + phone.Text + "','" + comboBox1.Text + " ','" + "สีขาว" + "','" + pin.Text + "','" + "กำลังดำเนินการ" + "','" + "กำลังดำเนินการ" + "','" + random_number + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                        conn.Open();
                        int rows = cmd1.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show(random_number.ToString(), "กรุณาจดจำเลขติดตามสินค้า", MessageBoxButtons.OK);

                            this.Hide();
                            Form10 wn = new Form10();
                            wn.Show();
                        }
                    }
                }
                else if (color3.Checked)
                {
                    Random random = new Random();
                    int random_number = random.Next();

                    MySqlConnection conn1 = databaseConnection();
                    conn.Open();
                    MySqlCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM pre_order WHERE product_number = '{random_number}'";
                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        conn.Close();
                        MessageBox.Show("มีข้อผิดพลาด", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //phone.Focus();
                    }
                    else
                    {
                        String sql1 = "INSERT INTO pre_order (name, address, phone_number, type, color, pin, payment_status, product_status, product_number, date) VALUES('" + tbname.Text + "','" + tbaddress.Text + "','" + phone.Text + "','" + comboBox1.Text + " ','" + "สีทอง" + "','" + pin.Text + "','" + "กำลังดำเนินการ" + "','" + "กำลังดำเนินการ" + "','" + random_number + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                        conn.Open();
                        int rows = cmd1.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show(random_number.ToString(), "กรุณาจดจำเลขติดตามสินค้า", MessageBoxButtons.OK);

                            this.Hide();
                            Form10 wn = new Form10();
                            wn.Show();
                        }
                    }
                }
            }
        }
    }
}
