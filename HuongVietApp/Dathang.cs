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
    public partial class DatHang : Form
    {
      
        int mamonanchon;
        int soluongmonanchon;
        int madonhang=0;
        DateTime curtime;
        int macuahang = 100;
        float tongtien = 0;
        float phiship = 20000;
        int thoigiangiao = 1;
        int selectedKenhdat;
        int trangthai = 1;
        int? makhachhang = 100000;
        int magiamgia = 400;
        int? manhanvien = 200001;
        Dictionary<int, int> monan_soluong = new Dictionary<int, int>();
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        static public class Thongtindathang
        {
            static public int madon;
        }
        public static object ToDBNull(object value)
        {
            if (null != value)
                return value;
            return DBNull.Value;
        }
        public DatHang()
        {
            InitializeComponent();

        
        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> comboSource2 = new Dictionary<int, string>();
            if(DangNhapNV.Thongtindangnhap.dnnv==true)
            {
                comboSource2.Add(2, "Đặt qua Điện thoại");
                comboSource2.Add(3, "Đặt tại quầy");
            }
            if (DangNhap.Thongtindangnhap.dnkh == true)
            {
                comboSource2.Add(1, "Đặt Online");
            }
            

            if (DangNhapNV.Thongtindangnhap.dnnv == true)
            {
                macuahang = DangNhapNV.Thongtindangnhap.MaCH;
                makhachhang = null;
                manhanvien = DangNhapNV.Thongtindangnhap.MaNV;
                lb_nhanvien.Text = DangNhapNV.Thongtindangnhap.TenNV;
                lb_phiship.Text = phiship.ToString();
                lb_thoigiangiao.Text = thoigiangiao.ToString();
                lb_time.Text = curtime.ToString(" hh : mm");
                lb_cuahang.Text =macuahang.ToString();
               

            }
            if (DangNhap.Thongtindangnhap.dnkh == true)
            {
                macuahang = DangNhap.Thongtindangnhap.MaCHtheoVitri;
                makhachhang = DangNhap.Thongtindangnhap.MaKH;
                manhanvien = null;
                lb_nhanvien.Text ="NULL";
                lb_phiship.Text = phiship.ToString();
                lb_thoigiangiao.Text = thoigiangiao.ToString();
                lb_time.Text = curtime.ToString(" hh : mm");
                lb_cuahang.Text = macuahang.ToString();
            }
            

            cbo_kenhdat.DataSource = new BindingSource(comboSource2, null);
            cbo_kenhdat.DisplayMember = "Value";
            cbo_kenhdat.ValueMember = "Key";
            DateTime tn = DateTime.Now;
            lb_time.Text = tn.ToString(" hh : mm");
            grid_monan.Visible = false;
            label21.Visible = false;
            lb_tongtien.Visible = false;
            btn_dathang.Visible = false;
            btn_themmon.Visible = false;
            label2.Visible = false;
            txt_soluong.Visible = false;
            FillDataGridView( grid_monan,"spLaydanhsachmonan");


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        void FillDataGridView(DataGridView dg,string storedname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(storedname, connection))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtb = new DataTable();
                    da.Fill(dtb);
                    dg.DataSource = dtb;
                  
                }
            }
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {

            double tongtien;
      
            //string magiamgia ="ANXECHIEU";
   

            DateTime curtime=DateTime.Now;
            foreach (KeyValuePair<int, int> kvp in monan_soluong)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("spThemchitietdonhang", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //madonhang++;
                        cmd.Parameters.Add(new SqlParameter("@madonhang", madonhang));
                        cmd.Parameters.Add(new SqlParameter("@mamonan", kvp.Key));
                        cmd.Parameters.Add(new SqlParameter("@soluong", kvp.Value));
                        cmd.ExecuteNonQuery();
                        
                    }
                    using (SqlCommand cmd2 = new SqlCommand("spGiamsoluongmonan", connection))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add(new SqlParameter("@mamonan", kvp.Key));
                        cmd2.Parameters.Add(new SqlParameter("@soluong", kvp.Value));
                        cmd2.Parameters.Add(new SqlParameter("@macuahang", macuahang));
                        cmd2.ExecuteNonQuery();

                    }

                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spLaytongtiendonhang", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@madonhang", madonhang));
                    tongtien = (double)cmd.ExecuteScalar();
                }

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spCapnhatthongtindonhang", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
                    cmd.Parameters.Add(new SqlParameter("@madon", madonhang));

                    int kq = cmd.ExecuteNonQuery();
                    if (kq == 1)
                    {
                        MessageBox.Show("Đơn hàng của bạn đang được tiếp nhận!!!");
                        Form tinhtrang = new Thanh_Toán();
                        tinhtrang.Show();
                    }
                    else
                        MessageBox.Show("Đặt hàng không thành công!!");
                }
            }
            


        }

        private void button1_Click(object sender, EventArgs e) //them vao gio hang
        {
           
            soluongmonanchon = 0;
           
            
            if (String.IsNullOrEmpty(txt_soluong.Text))
            {
                MessageBox.Show("Hãy chọn số lượng");

            }
            else
            {
                soluongmonanchon = int.Parse(txt_soluong.Text);
                if (monan_soluong.ContainsKey(mamonanchon))
                {
                    monan_soluong[mamonanchon] = soluongmonanchon;
                }   
                else
                {
                    monan_soluong.Add(mamonanchon, soluongmonanchon);
                }

                
                MessageBox.Show("Thêm món thành công");
                txt_soluong.Clear();
            }
            

            

        }

        private void grid_monan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            foreach (DataGridViewRow row in grid_monan.SelectedRows)
            {
                mamonanchon = (int)row.Cells[0].Value;
                
               
            }
        }

        private void btn_taodonhang_Click(object sender, EventArgs e)
        {
            selectedKenhdat = (int)cbo_kenhdat.SelectedValue;
           

            curtime = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spThemdondathang", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter ten = new SqlParameter("@tenkhach", SqlDbType.VarChar);
                    ten.Direction = ParameterDirection.Input;
                    ten.Value = txt_tenkhach.Text;
                    cmd.Parameters.Add(ten);
                    SqlParameter sodt = new SqlParameter("@sodienthoai", SqlDbType.VarChar);
                    sodt.Direction = ParameterDirection.Input;
                    sodt.Value = txt_sodt.Text;
                    cmd.Parameters.Add(sodt);
                    SqlParameter diachi = new SqlParameter("@diachi", SqlDbType.VarChar);
                    diachi.Direction = ParameterDirection.Input;
                    diachi.Value = txt_diachi.Text;
                    cmd.Parameters.Add(diachi);
                    //SqlParameter magiamgia = new SqlParameter("@magiamgia", SqlDbType.VarChar);
                    //magiamgia.Direction = ParameterDirection.Input;
                    //magiamgia.Value = txt_magiamgia.Text;
                    //cmd.Parameters.Add(magiamgia);
                    cmd.Parameters.Add(new SqlParameter("@magiamgia", magiamgia));
                    cmd.Parameters.Add(new SqlParameter("@ngaygio", curtime));
                    cmd.Parameters.Add(new SqlParameter("@macuahang", macuahang));
                    cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
                    cmd.Parameters.Add(new SqlParameter("@phiship", phiship));
                    cmd.Parameters.Add(new SqlParameter("@thoigiangiao", thoigiangiao));
                    cmd.Parameters.Add(new SqlParameter("@kenhdat", selectedKenhdat));
                    cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
                    cmd.Parameters.Add(new SqlParameter("@makhachhang", ToDBNull(makhachhang)));
                    cmd.Parameters.Add(new SqlParameter("@manhanvien", ToDBNull(manhanvien)));
                    madonhang = (int)cmd.ExecuteScalar();
                    Thongtindathang.madon = madonhang;
                    if (madonhang!=0)
                    {
                        MessageBox.Show("Thêm đơn hàng thành công");
                        grid_monan.Visible = true;
                        label21.Visible = true;
                        lb_tongtien.Visible = true;
                        btn_dathang.Visible = true;
                        btn_themmon.Visible = true;
                        btn_taodonhang.Visible = false;
                        label2.Visible = true;
                        txt_soluong.Visible = true;
                    }
                        
                    else
                        MessageBox.Show("Thêm thất bại!!");
                }
            }
        }

        private void grid_monan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_monan.ReadOnly = true;
        }
    }
}
