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
    public partial class QuanLyFoodCH : Form
    {
        string StrConnect = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(@"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True");

        public QuanLyFoodCH()
        {
            InitializeComponent();
        }

        
        private void QuanLyFoodCH_Load(object sender, EventArgs e)
        {
            lbMaCuaHang.Text = DangNhapNV.Thongtindangnhap.MaCH.ToString();
            FillDataGridView(); 
        }

      
        void FillDataGridView()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("spXemThongTinMonAn_CuaHang", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@macuahang", lbMaCuaHang.Text.Trim());
            da.SelectCommand.ExecuteNonQuery();
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dataGridView1.DataSource = dtb;
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e) // button sua so luong
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand sqlCmd = new SqlCommand("spSuaThongTinMonAn_CuaHang", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mamonan", txtMaMon.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@macuahang", lbMaCuaHang.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@soluong", txtSoLuong.Text.Trim());
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

            FillDataGridView();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.ReadOnly = true;
            row = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txtMaMon.Text = row.Cells[0].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
            }
            txtMaMon.Enabled = false;
        }
    }
}
