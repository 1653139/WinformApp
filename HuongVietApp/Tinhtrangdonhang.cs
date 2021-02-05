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
    public partial class Thanh_Toán : Form
    {
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
     
        public Thanh_Toán()
        {
            InitializeComponent();
        }
        void FillDataGridView(DataGridView dg, string storedname,int madon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(storedname, connection))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@madonhang", madon));
                    DataTable dtb = new DataTable();
                    da.Fill(dtb);
                    dg.DataSource = dtb;

                }
            }
        }
        private void Thanh_Toán_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("spLaythongtindonhang", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@madonhang", DatHang.Thongtindathang.madon));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lb_madonhang.Text= reader["MaDH"].ToString();
                            lb_ten.Text = reader["TenKhach"].ToString();
                            lb_sdt.Text = reader["SoDienThoai"].ToString();
                            lb_phiship.Text = reader["PhiShip"].ToString();
                            lb_time.Text = reader["NgayGio"].ToString();
                            lb_diachi.Text = reader["DiaChi"].ToString();
                            lb_mach.Text = reader["MaCuaHang"].ToString();
                            lb_magiamgia.Text = reader["MaGiamGia"].ToString();
                            lb_nhanvien.Text = reader["MaNhanVien"].ToString();
                            lb_thoigiangiao.Text = reader["ThoiGianGiao"].ToString();
                            lb_trangthai.Text = reader["TrangThai"].ToString();
                            lb_tongtien.Text = reader["TongTien"].ToString();

                        }
                    }
                }
                connection.Close();
            }

            FillDataGridView(grid_chitietdonhang,"spLaychitietdonhang",DatHang.Thongtindathang.madon);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_huydonhang_Click(object sender, EventArgs e)
        {
            int trangthai = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spCapnhattrangthaidonhang", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //madonhang++;
                    cmd.Parameters.Add(new SqlParameter("@madonhang", DatHang.Thongtindathang.madon));
                    cmd.Parameters.Add(new SqlParameter("@trangthai",trangthai));


                    cmd.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Đã hủy đơn hàng!!!");
        }

        private void grid_chitietdonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_chitietdonhang.ReadOnly = true;
        }
    }
}
