
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.Model;

namespace BanGiay
{
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {            
            InitializeComponent();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult okOrCancel = new DialogResult();
            okOrCancel = MessageBox.Show("Bạn có muốn thoát hay không ?", "Đăng Nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (okOrCancel != DialogResult.OK) e.Cancel = true ; // không cho phép event này được thực thi 
        }
        public static int check = 0; 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //frmGiaoDien gd = new frmGiaoDien();
            //this.Hide(); // ẩn đi form đăng nhập ;
            //gd.ShowDialog(); // show form giao diện và buộc thực thi trên form giao diện 
            // this.Show(); // hiện lại form đăng nhập 
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);

            }
            else if (txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu  ", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                using (QLBANGIAYEntities1 db = new QLBANGIAYEntities1())
                {
                    var tk = db.tblDangNhaps.Where(p => p.TenTaiKhoan.Equals(txtTenTaiKhoan.Text)).FirstOrDefault();
                    if (tk != null)
                    {
                        if (tk.MatKhau.Equals(txtMatKhau.Text))
                        {
                            var ad = tk.PhanQuyen;
                            if (ad == 1)
                            {
                                MessageBox.Show("Ban dang nhap vao tai khoan Admin", "Thông báo", MessageBoxButtons.OK);
                                frmDanhMucQuanLy a1 = new frmDanhMucQuanLy();
                                check = 1; 
                                this.Hide();
                                a1.ShowDialog();
                                this.Show();
                            }
                            if (ad == 2)
                            {
                                MessageBox.Show("Ban dang nhap vao tai khoan Nhân Viên", "Thông báo", MessageBoxButtons.OK);
                                frmDanhMucNhanVien a1 = new frmDanhMucNhanVien();
                                check = 2; 
                                this.Hide();
                                a1.ShowDialog();
                                this.Show();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Bạn đẫ nhập sai mật khẩu!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đẫ nhập sai Tài khoản!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = "admin";
            txtMatKhau.Text = "admin123";
        }
    }
}
