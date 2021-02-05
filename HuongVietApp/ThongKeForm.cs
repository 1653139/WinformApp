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
    public partial class ThongKeForm : Form
    {
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        int selectedTKValue;
        int selectedCHValue;
        int selectedHTValue;
        int selectedTMValue;
        int selectedLMValue;
        int selectedLKValue;
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            cbo_KenhDatHang.Visible = false;
            cbo_Loaimon.Visible = false;
            cbo_Monan.Visible = false;
            cbo_Loaikhach.Visible = false;

            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Value = DateTime.Today;
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(0, "Tất cả");
            comboSource.Add(1, "Thống kê theo kênh đặt hàng ");
            comboSource.Add(2, "Thống kê theo món");
            comboSource.Add(3, "Thống kê theo loại món");
            comboSource.Add(4, "Thống kê theo loại khách hàng");
            comboSource.Add(5, "Thống kê tỉ lệ hủy đơn hàng theo kênh đặt hàng");
            comboSource.Add(6, "Thống kê tỉ lệ hủy đơn hàng theo loại khách hàng");
     
            cbo_LoaiThongKe.DataSource = new BindingSource(comboSource, null);
            cbo_LoaiThongKe.DisplayMember = "Value";
            cbo_LoaiThongKe.ValueMember = "Key";

            //hinh thuc dat
            Dictionary<int, string> comboSource2 = new Dictionary<int, string>();
            comboSource2.Add(0, "Tất cả");
            comboSource2.Add(1, "Đặt Online");
            comboSource2.Add(2, "Đặt qua Điện thoại");
            comboSource2.Add(3, "Đặt tại quầy");

            cbo_KenhDatHang.DataSource = new BindingSource(comboSource2, null);
            cbo_KenhDatHang.DisplayMember = "Value";
            cbo_KenhDatHang.ValueMember = "Key";

            //Cua hang
            Dictionary<int, string> comboSource3 = new Dictionary<int, string>();
            if (DangNhapNV.Thongtindangnhap.role == 0)
            {
                comboSource3.Add(0, "Tất cả");
            }
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("spLaydanhsachcuahangtheochucvu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@chucvu", DangNhapNV.Thongtindangnhap.role));
                    cmd.Parameters.Add(new SqlParameter("@macuahang", DangNhapNV.Thongtindangnhap.MaCH));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboSource3.Add((int)reader["MaCH"], reader["TenCH"].ToString());

                        }
                    }
                }
                connection.Close();
            }

            cbo_ChiNhanh.DataSource = new BindingSource(comboSource3, null);
            cbo_ChiNhanh.DisplayMember = "Value";
            cbo_ChiNhanh.ValueMember = "Key";
            //Mon an
            Dictionary<int, string> comboSource4 = new Dictionary<int, string>();
            comboSource4.Add(0, "Tất cả");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("spLaydanhsachmonan", connection))
                {
                    using (SqlDataReader reader =cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboSource4.Add((int)reader["MaMA"], reader["TenMonAn"].ToString());
                        }
                    }
                }
                connection.Close();
            }
            cbo_Monan.DataSource = new BindingSource(comboSource4, null);
            cbo_Monan.DisplayMember = "Value";
            cbo_Monan.ValueMember = "Key";
            //loaimon
            Dictionary<int, string> comboSource5 = new Dictionary<int, string>();
            comboSource5.Add(0, "Tất cả");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("spLaydanhsachloaimon", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboSource5.Add((int)reader["MaLM"], reader["LoaiMon"].ToString());
                        }
                    }
                }
            }
            cbo_Loaimon.DataSource = new BindingSource(comboSource5, null);
            cbo_Loaimon.DisplayMember = "Value";
            cbo_Loaimon.ValueMember = "Key";
            //loai khach hang
            Dictionary<int, string> comboSource6 = new Dictionary<int, string>();
            comboSource6.Add(0, "Tất cả");
            comboSource6.Add(1, "Hạng silver");
            comboSource6.Add(2, "Hạng Gold");
            comboSource6.Add(3, "Hạng Diamond");
      

            cbo_Loaikhach.DataSource = new BindingSource(comboSource6, null);
            cbo_Loaikhach.DisplayMember = "Value";
            cbo_Loaikhach.ValueMember = "Key";
            //connection.Open();
            //SqlDataReader myReader = null;
            //SqlCommand myCommand = new SqlCommand("select * from DonDatHang ", connection);
            //myReader = myCommand.ExecuteReader();
            //while (myReader.Read())
            //{
            //    label20.Text = myReader["PhiShip"].ToString();

            //}


            //myReader.Close();


        }

        private void thongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_thongke.ReadOnly = true;
        }

 
        private void cbo_LoaiThongKe_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            DateTime iDate1,iDate2;
            iDate1 = dateTimePicker1.Value;
            iDate2 = dateTimePicker2.Value;
            selectedTKValue = (int)cbo_LoaiThongKe.SelectedValue;
            selectedHTValue = (int)cbo_KenhDatHang.SelectedValue;
            selectedCHValue = (int)cbo_ChiNhanh.SelectedValue;
            selectedTMValue=(int)cbo_Monan.SelectedValue; ;
            selectedLMValue= (int)cbo_Loaimon.SelectedValue; 
            selectedLKValue= (int)cbo_Loaikhach.SelectedValue; 
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = new SqlCommand("spGetDataFromDonDatHangForThongke", connection);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@LoaiThongKe", selectedTKValue));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@BeginDate", iDate1));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@EndDate", iDate2));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@MaCuaHang", selectedCHValue));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@HinhThuc", selectedHTValue));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@MaMonAn", selectedTMValue));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@MaLoaiMon", selectedLMValue));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@LoaiKhach", selectedLKValue));
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    adapter.Dispose();
                    grid_thongke.DataSource = table;
                }
            }
        }

        private void cbo_LoaiThongKe_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            cbo_KenhDatHang.Visible = false;
            cbo_Loaimon.Visible = false;
            cbo_Monan.Visible = false;
            cbo_Loaikhach.Visible = false;
            var selectedValue = (int)cbo_LoaiThongKe.SelectedValue;

            if (selectedValue == 1)
            {
                label7.Visible = true;
                cbo_KenhDatHang.Visible = true;
            }
            else if (selectedValue == 2)
            {
                label8.Visible = true;
                cbo_Monan.Visible = true;
            }
            else if (selectedValue == 3)
            {
                label9.Visible = true;
                cbo_Loaimon.Visible = true;
            }
            else if (selectedValue == 4)
            {
                label10.Visible = true;
                cbo_Loaikhach.Visible = true;
            }
            else if (selectedValue == 5)
            {
                label7.Visible = true;
                cbo_KenhDatHang.Visible = true;
            }
            else if (selectedValue == 6)
            {
                label10.Visible = true;
                cbo_Loaikhach.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
