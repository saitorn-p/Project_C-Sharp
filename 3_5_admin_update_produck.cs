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
    public partial class Form18 : Form
    {
        private MySqlConnection databaseConnection() 
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_c-sharp;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void showorder()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open(); 
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM pre_order WHERE product_status != \"จัดส่งสินค้าเรียบร้อยแล้ว\"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds); 
            conn.Close();

            dataorder.DataSource = ds.Tables[0].DefaultView;

            dataorder.Columns[2].Visible = false; 
            dataorder.Columns[4].Visible = false; 
            dataorder.Columns[5].Visible = false; 
            dataorder.Columns[6].Visible = false; 
            dataorder.Columns[7].Visible = false;
            dataorder.Columns[9].Visible = false; 
            dataorder.Columns[11].Visible = false; 

            dataorder.Columns[0].Width = 80; 
            dataorder.Columns[1].Width = 200; 
            dataorder.Columns[3].Width = 140; 
            dataorder.Columns[8].Width = 150;
            dataorder.Columns[10].Width = 200;
        }
        public Form18()
        {
            InitializeComponent();
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 wn = new Form11();
            wn.Show();
        }

        private void checking_CheckedChanged(object sender, EventArgs e)
        {
            tbupdate.Text = "กำลังรอสินค้า";
        }

        private void preparing_CheckedChanged(object sender, EventArgs e)
        {
            tbupdate.Text = "กำลังเตรียมการจัดส่ง";
        }

        private void finished_CheckedChanged(object sender, EventArgs e)
        {
            tbupdate.Text = "จัดส่งสินค้าเรียบร้อยแล้ว";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataorder.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataorder.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            string sql = "UPDATE pre_order SET product_status = '" + tbupdate.Text + "',tracking = '"+tbTracking.Text+"' WHERE ID = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("อัพเดตข้อมูลสำเร็จ","Message");
                showorder();
            }
        }

        private void dataorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataorder.CurrentRow.Selected = true;
            tbupdate.Text = dataorder.Rows[e.RowIndex].Cells["product_status"].FormattedValue.ToString();
            tbTracking.Text = dataorder.Rows[e.RowIndex].Cells["tracking"].FormattedValue.ToString();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            showorder();
        }
    }
}
