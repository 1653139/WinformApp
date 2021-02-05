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
    public partial class Nhân_viên : Form
    {
        int madonhang;
        static string connectionString = @"Data Source=THUCHENRY\SQL1653139;Initial Catalog=huongvietdb;Integrated Security=True";

        public Nhân_viên()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_donhang.ReadOnly = true;
        }


        void FillDataGridView(DataGridView dg, string storedname,int macuahang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(storedname, connection))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@macuahang", macuahang));
                    DataTable dtb = new DataTable();
                    da.Fill(dtb);
                    dg.DataSource = dtb;

                }
            }
        }
        private void Nhân_viên_Load_1(object sender, EventArgs e)
        {
            lb_tencuahang.Text = DangNhapNV.Thongtindangnhap.MaCH.ToString();
            FillDataGridView(grid_donhang, "spLaydanhsachdonhang",DangNhapNV.Thongtindangnhap.MaCH);

        }

        private void button1_Click(object sender, EventArgs e)//capnhattrangtrai
        {

            if (String.IsNullOrEmpty(txt_trangthai.Text))
            {
                MessageBox.Show("Hãy nhập trạng thái");

            }
            else
            {
                int trangthai = int.Parse(txt_trangthai.Text);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("spCapnhattrangthaidonhang", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //madonhang++;

                        cmd.Parameters.Add(new SqlParameter("@madonhang", madonhang));
                        cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));


                        cmd.ExecuteNonQuery();
                    }

                }


                MessageBox.Show("Cập nhật thành công");
                txt_trangthai.Clear();
            }

           
        }

        private void grid_donhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in grid_donhang.SelectedRows)
            {
                madonhang = (int)row.Cells[0].Value;


            }
        }
    }
}