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
    public partial class DangNhap : Form
    {
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        static public class Thongtindangnhap
        {
            static public int loaiKH;
            static public int MaCH;
            static public string TenKH;
            static public int MaKH;
            static public int MaCHtheoVitri;
            static public bool dnkh=false;

        }
        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {

          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spDangnhapKhachhang", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar);
                    email.Direction = ParameterDirection.Input;
                    email.Value = txt_email.Text;
                    cmd.Parameters.Add(email);
                    SqlParameter matkhau = new SqlParameter("@matkhau", SqlDbType.VarChar);
                    matkhau.Direction = ParameterDirection.Input;
                    matkhau.Value = txt_matkhau.Text;
                    cmd.Parameters.Add(matkhau);
                  
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Thongtindangnhap.MaCH = (int)reader["MaCuaHang"];
                            Thongtindangnhap.TenKH = reader["Ten"].ToString();
                            Thongtindangnhap.loaiKH = (int)reader["LoaiKH"];
                            Thongtindangnhap.MaKH= (int)reader["MaTV"];

                        }
                        if (Thongtindangnhap.TenKH == null)
                        {
                            MessageBox.Show("Đăng nhập thất bại");
                        }
                        else
                        {
                       
                            DangNhap.Thongtindangnhap.dnkh = true;
                            Form vitri = new Vitri();
                            vitri.Show();
                        }



                    }

                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
        }

        private void btn_datmon_Click(object sender, EventArgs e)
        {
            Form vitri = new Vitri();
            vitri.Show();
        }
    }
}
