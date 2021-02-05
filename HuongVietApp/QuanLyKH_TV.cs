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
    public partial class QuanLyKH_TV : Form
    {
        string StrConnect = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(@"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True");
        int k;
        public QuanLyKH_TV()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyKH_TV_Load(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            SqlDataAdapter da;
            //------------------------------------------------------------------------------tao ma thanh vien moi
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand cmd = new SqlCommand("spLayMaKhachHangThanhVien", connection);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                k = (int)red["MaTV"];
            }
            k++;
            lbMaKH.Text = k.ToString();
            red.Close();
            cmd.Dispose();
            //-------------------------------------------------------------------------------------------------------
            // load combobox ma cua hang

            lb_macuahang.Text = DangNhapNV.Thongtindangnhap.MaCH.ToString();

            //-------------------------------------------------------------------------------------------------------
            // load combobox cua loai khach hang
            cbLoaiKH.Items.Clear();
            da = new SqlDataAdapter("select distinct LoaiKH from KH_ThanhVien", connection);
            dtb = new DataTable();
            da.Fill(dtb);
            da.Dispose();

            foreach (DataRow dr in dtb.Rows)
            {
                cbLoaiKH.Items.Add(dr["LoaiKH"].ToString());
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
            SqlDataAdapter da = new SqlDataAdapter("spXemBangKhachHangThanhVien", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@macuahang", lb_macuahang.Text.Trim());
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            if (x == 1)
                dataGridView1.DataSource = dtb;
            else
                    if (x == 2) dataGridView2.DataSource = dtb;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.CurrentRow.Index != -1)
            {
                lbMaKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNgaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbLoaiKH.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtMK.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lb_macuahang.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                button1.Enabled = false;
               // cbMaCH.Enabled = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                lb2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                lb3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                lb4.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                lb5.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                lb6.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                lb7.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                lb8.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spThemKhachHangThanhVien", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ten", txtTen.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@ngaysinh", txtNgaySinh.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@loaikh", cbLoaiKH.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@matkhau", txtMK.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@macuahang", lb_macuahang.Text.Trim());
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spSuaThongTinKhachHangThanhVien", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mathanhvien", lbMaKH.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@ten", txtTen.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@ngaysinh", txtNgaySinh.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@loaikh", cbLoaiKH.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@matkhau", txtMK.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@macuahang",  lb_macuahang.Text.Trim());
            //int kq = sqlCmd.ExecuteNonQuery();
            //if (kq == 1)
            //{
            //    MessageBox.Show("Sửa thành công!!!");
            //}
            //else
            //{
            //    MessageBox.Show("Sửa Thất bại!!!");
            //}
            connection.Close();

            FillDataGridView(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spXoaKHachHangThanhVien", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mathanhvien", lb2.Text.Trim());
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
    }
}
