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
    public partial class DangNhapNV : Form
    {
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        int selectedCNValue;
        public DangNhapNV()
        {
            InitializeComponent();
        }
        static public class Thongtindangnhap
        {
            static public int role;
            static public int MaCH;
            static public string TenNV;
            static public int MaNV;
            static public bool dnnv = false;
        }
        private void DangNhapNV_Load(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
            Dictionary<int, string> comboSource3 = new Dictionary<int, string>();
            comboSource3.Add(0, "Tất cả");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("spLaydanhsachcuahang", connection))
                {
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
            cbo_Chinhanh.DataSource = new BindingSource(comboSource3, null);
            cbo_Chinhanh.DisplayMember = "Value";
            cbo_Chinhanh.ValueMember = "Key";

        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {

            selectedCNValue = (int)cbo_Chinhanh.SelectedValue;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spDangnhap", connection))
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
                    cmd.Parameters.Add(new SqlParameter("@macuahang", selectedCNValue));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            if (reader.IsDBNull(reader.GetOrdinal("MaCuaHang")))
                            {
                                Thongtindangnhap.MaCH = 0;
                                
                            }
                            else
                            {
                                Thongtindangnhap.MaCH = (int)reader["MaCuaHang"];
                            }
                            
                            Thongtindangnhap.TenNV = reader["Ten"].ToString();
                            Thongtindangnhap.role = (int)reader["ChucVu"];
                            Thongtindangnhap.MaNV=(int)reader["MaNV"];

                        }
                        if (Thongtindangnhap.TenNV == null)
                        {
                            MessageBox.Show("Đăng nhập thất bại");
                        }
                        else {
                            DangNhapNV.Thongtindangnhap.dnnv = true;
                            Form chucnang = new HuongvietChucNang();
                            chucnang.Show();
                            
                        }



                    }

                }
            }

        }
   
        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
