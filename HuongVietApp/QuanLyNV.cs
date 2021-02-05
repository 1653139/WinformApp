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
    public partial class QuanLyNV : Form
    {
        string StrConnect = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(@"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True");
        int k;

        public QuanLyNV()
        {
            InitializeComponent();
        }

        private void QuanLyNV_Load(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            SqlDataAdapter da;
            // tao ma NV mơi
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand cmd = new SqlCommand("spLayMaNhanVien", connection);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                k = (int)red["MaNV"];
            }
            k++;
            lbMaNV1.Text = k.ToString();
            red.Close();
            cmd.Dispose();
            //-------------------------------------------------------------------------------------------------------
            // load combobox Chuc vu 
            cbChucVu1.Items.Clear();
            da = new SqlDataAdapter("select distinct ChucVu from NhanVien", connection);
            dtb = new DataTable();
            da.Fill(dtb);
            da.Dispose();

            foreach (DataRow dr in dtb.Rows)
            {
                cbChucVu1.Items.Add(dr["ChucVu"].ToString());
            }
            dtb.Clear();

            //-------------------------------------------------------------------------------------------------------
            // load combobox cua hang
            cbMaCH1.Items.Clear();
            da = new SqlDataAdapter("select MaCH from CuaHang", connection);
            dtb = new DataTable();
            da.Fill(dtb);
            da.Dispose();

            foreach (DataRow dr in dtb.Rows)
            {
                cbMaCH1.Items.Add(dr["MaCH"].ToString());
            }
            dtb.Clear();
            //-------------------------------------------------------------------------------------------------------
            FillDataGridView(1);
            FillDataGridView(2);
        }

        void FillDataGridView(int x)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("spXemBangNhanVien", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@soluong", 0);
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

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // button them 
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spThemNhanVien", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ten", txtTenNV1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@email", txtEmailNV1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@chucvu", cbChucVu1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@matkhau", txtMatKhau1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@macuahang", cbMaCH1.Text.Trim());
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

        private void button2_Click(object sender, EventArgs e) // button sua
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spSuaThongTinNhanVien", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@manhanvien", lbMaNV1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@ten", txtTenNV1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@email", txtEmailNV1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@chucvu", cbChucVu1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@matkhau", txtMatKhau1.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@macuahang", cbMaCH1.Text.Trim());
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

        private void button4_Click(object sender, EventArgs e) // button xoa
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spXoaNhanVien", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@manhanvien", Convert.ToInt32(lb1.Text.Trim()));
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
                lb1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                lb2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                lb3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                lb4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                lb5.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                lb6.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.CurrentRow.Index != -1)
            {
                lbMaNV1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenNV1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtEmailNV1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbChucVu1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtMatKhau1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cbMaCH1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                button1.Enabled = false;
            }
        }
    }
}
