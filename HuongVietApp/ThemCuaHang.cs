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
    public partial class ThemCuaHang : Form
    {
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        string selectedTPvalue;
        string selectedQvalue;
        public ThemCuaHang()
        {
            InitializeComponent();
        }

        private void ThemCuaHang_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSourcetp = new Dictionary<string, string>();
            comboSourcetp.Add("hcm", "Thành phố HCM");
            comboSourcetp.Add("hn", "Thành phố Hà Nội");
            comboSourcetp.Add("dn", "Thành phố Đà Nẵng");
            comboSourcetp.Add("bmt", "Thành phố Buôn mê thuật");
            cbo_thanhpho.DataSource = new BindingSource(comboSourcetp, null);
            cbo_thanhpho.DisplayMember = "Value";
            cbo_thanhpho.ValueMember = "Key";

            Dictionary<string, string> comboSourcequan = new Dictionary<string, string>();
            comboSourcequan.Add("qtb", "Quận Tân Bình");
            comboSourcequan.Add("q5", "Quận 5");
            comboSourcequan.Add("q3", "Quận 3");
            comboSourcequan.Add("q11", "Quận 11");
            cbo_quan.DataSource = new BindingSource(comboSourcequan, null);
            cbo_quan.DisplayMember = "Value";
            cbo_quan.ValueMember = "Key";
        }

        private void btn_themchinhanh_Click(object sender, EventArgs e)
        {
            selectedTPvalue = (string)cbo_thanhpho.SelectedValue;
            selectedQvalue = (string)cbo_quan.SelectedValue;
            string diachichon = selectedQvalue + ',' + selectedTPvalue;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spThemcuahang", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter tencuahang = new SqlParameter("@tencuahang", SqlDbType.VarChar);
                    tencuahang.Direction = ParameterDirection.Input;
                    tencuahang.Value = txt_tenchinhanh.Text;
                    cmd.Parameters.Add(tencuahang);
                    SqlParameter diachi = new SqlParameter("@diachi", SqlDbType.VarChar);
                    diachi.Direction = ParameterDirection.Input;
                    diachi.Value = diachichon;
                    cmd.Parameters.Add(diachi);
                    int kq = cmd.ExecuteNonQuery();
                    if (kq == 1)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Lỗi không thể thêm món");

                }
            }

        }
    }
}
