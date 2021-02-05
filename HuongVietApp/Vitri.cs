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
    public partial class Vitri : Form
    {
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
      
        string selectedTPvalue;
        string selectedQvalue;
        Dictionary<int, string> dsdiachi = new Dictionary<int, string>();
        public Vitri()
        {
            InitializeComponent();
        }

        private void Vitri_Load(object sender, EventArgs e)
        {
            //thanhpho
            Dictionary<string, string> comboSourcetp = new Dictionary<string, string>();
            comboSourcetp.Add("hcm", "Thành phố HCM");
            cbo_thanhpho.DataSource = new BindingSource(comboSourcetp, null);
            cbo_thanhpho.DisplayMember = "Value";
            cbo_thanhpho.ValueMember = "Key";

            Dictionary<string, string> comboSourcequan = new Dictionary<string , string>();
            comboSourcequan.Add("qtb", "Quận Tân Bình");
            comboSourcequan.Add("q5", "Quận 5");
            comboSourcequan.Add("q3", "Quận 3");
            comboSourcequan.Add("q11", "Quận 11");
            cbo_quan.DataSource = new BindingSource(comboSourcequan, null);
            cbo_quan.DisplayMember = "Value";
            cbo_quan.ValueMember = "Key";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("spLaydanhsachcuahang", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsdiachi.Add((int)reader["MaCH"], reader["DiaChi"].ToString());
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            selectedTPvalue = (string)cbo_thanhpho.SelectedValue;
            selectedQvalue = (string)cbo_quan.SelectedValue;
            string vitri = selectedQvalue + ',' + selectedTPvalue;
            DangNhap.Thongtindangnhap.MaCHtheoVitri = TimCN(vitri, dsdiachi);
            Form datmon = new DatHang();
            datmon.Show();

        }
        static int CompareCN(string str1, string str2)
        {
            string[] arrListStr1 = str1.Split(',');
            string[] arrListStr2 = str2.Split(',');
            for (int i = 1; i >= 0; i--)
            {
                if (String.Compare(arrListStr1[i], arrListStr2[i], true) != 0) return 1 - i;
            }
            return 2;
        }
        public int TimCN(string KHnhap,Dictionary<int, string> dc)
        {
            int tmp, kq = -1, max = -1;

            foreach (int key in dc.Keys)
            {
                tmp = CompareCN(KHnhap, dc[key]);
                if (tmp == 2) return key;
                if (tmp > max)
                {
                    max = tmp;
                    kq = key;
                }
            }
            return kq;

        }
    }
}
