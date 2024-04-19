using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.DAL;
using BanGiay.Model;

namespace BanGiay
{
    public partial class frmThongKe : Form
    {
        GetDanhSachDAL ds; 
        public frmThongKe()
        {
            ds = new GetDanhSachDAL();
            InitializeComponent();
        }

        string ten = "";

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachNhanVien();
            ten = "THÔNG TIN NHÂN VIÊN";            
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachHoaDon();
            ten = "THÔNG TIN HÓA ĐƠN";
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachKhachHang();
            ten = "THÔNG TIN KHÁCH HÀNG";
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachSanPham();
            ten = "THÔNG TIN SẢN PHẨM";
        }
        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachChiTietHoaDon();
            ten = "THÔNG TIN CHI TIẾT HÓA ĐƠN";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (txtTenFile.Text == "")
            {
                MessageBox.Show("Bạn hãy đặt tên cho file trước khi xuất Excel ! ", "Thông báo ", MessageBoxButtons.OK);
                txtTenFile.Focus();
            }
            else
            {
                string ngaythang = dateNgayThang.Value.ToString();
                string tenbang = ten;
                string tenfile = txtTenFile.Text.Trim();
                string duongdan = @"C:\Users\eTivL\OneDrive\Desktop\CongNghePhanMem\BaoCaoCuoiKi\BanGiay";
                XuatExcel.XuatExcelThongKe(dgvDanhSach, duongdan, tenfile, tenbang, ngaythang);
                string mofile = duongdan + tenfile + ".xlsx";
                Process.Start(@"" + mofile);
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            if(frmDangNhap.check == 1)
            {
                btnNhanVien.Enabled = true; 
            }else
            {
                btnNhanVien.Enabled = false;
            }
        }
    }
}
