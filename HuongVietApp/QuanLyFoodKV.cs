using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HuongVietApp
{
    public partial class QuanLyFoodKV : Form
    {
        string StrConnect = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(@"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True");
        int k;

        public QuanLyFoodKV()
        {
            InitializeComponent();
        }

        private void QuanLyFoodKV_Load(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            SqlDataAdapter da;
            // ---------------------------------------------------------------------------tao Ma Mon An mơi 
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand cmd = new SqlCommand("spLayMaMonAn", connection);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                k = (int)red["MaMA"];
            }
            k++;
            lb1.Text = k.ToString();
            red.Close();
            cmd.Dispose();
            //-------------------------------------------------------------------------------------------------------
            // load combobox Chuc vu 
            cbThuocLoaiMon.Items.Clear();
            da = new SqlDataAdapter("select distinct MaLoaiMon from MonAn", connection);
            dtb = new DataTable();
            da.Fill(dtb);
            da.Dispose();

            foreach (DataRow dr in dtb.Rows)
            {
                cbThuocLoaiMon.Items.Add(dr["MaLoaiMon"].ToString());
            }
            dtb.Clear();
            //-------------------------------------------------------------------------------------------------------
            FillDataGridView(1);
            FillDataGridView(2);
            //-------------------------------------------------------------------------------------------------------
        }
        void FillDataGridView(int x)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("spXemBangMonAn", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            if (x == 1)
                dataGridView1.DataSource = dtb;
            else
                    if (x == 2) dataGridView2.DataSource = dtb;
            connection.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e) // button them 
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spThemMonAn", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tenmonan", txtMonAn.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@giatien", txtGiaTien.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@maloaimon", cbThuocLoaiMon.Text.Trim());
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công!!!");
            }
            else
            {
                MessageBox.Show("Thêm Thất bại!!!");
            }
            connection.Close();

            FillDataGridView(1);

        }

        private void button2_Click_1(object sender, EventArgs e) // button sua
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spSuaThongTinMonAn", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mamonan", lb1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@tenmonan", txtMonAn.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@giatien", txtGiaTien.Text.Trim());
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công!!!");
            }
            else
            {
                MessageBox.Show("Sửa Thất bại!!!");
            }
            connection.Close();

            FillDataGridView(1);
        }

        private void button4_Click_1(object sender, EventArgs e) // button xoa
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spXoaMonAn", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mamonan", Convert.ToInt32(lb2.Text.Trim()));
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq == 1)
            {
                MessageBox.Show("Xóa thành công!!!");
            }
            else
            {
                MessageBox.Show("Xóa Thất bại!!!");
            }
            connection.Close();

            FillDataGridView(2);
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                lb2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                lb3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                lb4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                lb5.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.CurrentRow.Index != -1)
            {
                lb1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMonAn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cbThuocLoaiMon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtGiaTien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                button1.Enabled = false;
                cbThuocLoaiMon.Enabled = false;
            }
        }

       
    }
}
