using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuongVietApp
{
    public partial class HuongvietChucNang : Form
    {
        public HuongvietChucNang()
        {
            InitializeComponent();
        }



        private void HuongvietChucNang_Load(object sender, EventArgs e)
        { 

            btn_themcuahang.Visible = false;
            btn_themloaimon.Visible = false;
            btn_quanlynhanvien.Visible = false;
            btn_quanlymonan.Visible = false;
            btn_thongke.Visible = false;
            btn_datmon.Visible = false;
            btn_quanlydonhang.Visible = false;
            btn_themsoluongmon.Visible = false;
            btn_quanlykhachhang.Visible = false;
            if (DangNhapNV.Thongtindangnhap.role == 0)
            {
                btn_themcuahang.Visible = true;
                btn_themloaimon.Visible = true;
                btn_quanlynhanvien.Visible = true;
                btn_quanlymonan.Visible = true;
                btn_thongke.Visible = true;

            }
            if (DangNhapNV.Thongtindangnhap.role == 1)
            {
                btn_thongke.Visible = true;
                btn_datmon.Visible = true;
                btn_quanlydonhang.Visible = true;
                btn_themsoluongmon.Visible = true;
                btn_quanlykhachhang.Visible = true;
            }
            if (DangNhapNV.Thongtindangnhap.role == 2)
            {
                btn_datmon.Visible = true;
                btn_quanlydonhang.Visible = true;
            }


        }

        private void btn_datmon_Click(object sender, EventArgs e)
        {
            Form dathang= new DatHang();
            dathang.Show();

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            Form Thongke = new ThongKeForm();
            Thongke.Show();
        }



        private void btn_quanlykhachhang_Click(object sender, EventArgs e)
        {
            Form quanlykhachhang = new QuanLyKH_TV();
            quanlykhachhang.Show();
        }

        private void btn_quanlymonkhuvuc_Click(object sender, EventArgs e)
        {
            Form quanlymonkhuvuc = new QuanLyFoodKV();
            quanlymonkhuvuc.Show();
        }

        private void btn_quanlynhanvien_Click(object sender, EventArgs e)
        {
            Form quanlynhanvien = new QuanLyNV();
            quanlynhanvien.Show();

        }

        private void btn_quanlydonhang_Click(object sender, EventArgs e)
        {
            Form quanlydonhang = new Nhân_viên();
            quanlydonhang.Show();
        }

        private void btn_themsoluongmon_Click(object sender, EventArgs e)
        {
            Form themsoluongmon = new QuanLyFoodCH();
            themsoluongmon.Show();
        }

        private void btn_themcuahang_Click(object sender, EventArgs e)
        {
            Form themcuahang = new ThemCuaHang();
            themcuahang.Show();
        }

        private void btn_themloaimon_Click(object sender, EventArgs e)
        {
            Form themloaimon= new ThemLoaiMon();
            themloaimon.Show();
        }
    }
}
