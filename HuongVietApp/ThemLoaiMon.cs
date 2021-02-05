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
    public partial class ThemLoaiMon : Form
    {
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        public ThemLoaiMon()
        {
            InitializeComponent();
        }

        private void ThemLoaiMon_Load(object sender, EventArgs e)
        {

        }

        private void btn_themloaimon_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("spThemloaimon", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter tenloaimon = new SqlParameter("@tenloaimon", SqlDbType.VarChar);
                    tenloaimon.Direction = ParameterDirection.Input;
                    tenloaimon.Value = txt_tenloaimon.Text;
                    cmd.Parameters.Add(tenloaimon);
                    int kq = cmd.ExecuteNonQuery();
                    if(kq==1)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Lỗi không thể thêm món");

                }
            }
        }
    }
}
