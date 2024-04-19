using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.DAL;
using BanGiay.Model;

namespace BanGiay
{
    public partial class frmThayDoiDangNhap : Form
    {
        GetDanhSachDAL ds;
        tblDangNhap dn; 
        public frmThayDoiDangNhap()
        {
            ds = new GetDanhSachDAL();
            dn = new tblDangNhap();
            InitializeComponent();
        }
        public void SetDataGridView()
        {
            dgvTaiKhoan.DataSource = ds.GetDanhSachDangNhap();
        }
        public void Clear()
        {
            cmbTimKiem.DataSource = ds.GetDanhSachDangNhap();
            cmbMaNhanVien.DataSource = ds.GetDanhSachNhanVien();
            cmbTenNhanVien.DataSource = ds.GetDanhSachNhanVien();
            cmbTimKiem.ValueMember = "TenTaiKhoan";
            cmbMaNhanVien.ValueMember = "TenNhanVien";
            cmbMaNhanVien.DisplayMember = "MaNhanVien";
            cmbTenNhanVien.ValueMember = "TenNhanVien";
            txtMatKhau.Text = txtTaiKhoan.Text  = string.Empty;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTaiKhoan.ReadOnly = false;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThayDoiDangNhap_Load(object sender, EventArgs e)
        {
            Clear();
            SetDataGridView();
        }

        private void dgvTaiKhoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dn.TenTaiKhoan = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colTenTaiKhoan"].Value);
            using (QLBANGIAYEntities1 db = new QLBANGIAYEntities1())
            {
                dn = db.tblDangNhaps.Where(p => p.TenTaiKhoan == dn.TenTaiKhoan).FirstOrDefault();
                txtTaiKhoan.Text = dn.TenTaiKhoan.ToString();
                txtMatKhau.Text = dn.MatKhau.ToString();
                cmbMaNhanVien.Text = dn.MaNhanVien.ToString();
                string check = dgvTaiKhoan.CurrentRow.Cells["colPhanQuyen"].Value.ToString();
                if (String.Compare(check, "2") == 0)
                    rbNhanVien.Checked = true;
                else
                    rbQuanLy.Checked = true;
            }
                
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtTaiKhoan.ReadOnly = true; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnDong.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            txtTaiKhoan.ReadOnly = false;

            Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dn.TenTaiKhoan = txtTaiKhoan.Text.Trim();
            dn.MatKhau = txtMatKhau.Text.Trim();
            dn.MaNhanVien = cmbMaNhanVien.Text;
            if (rbNhanVien.Checked == true)
            {
                dn.PhanQuyen = 2;
            }
            else
            {
                dn.PhanQuyen = 1;
            }
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                using (QLBANGIAYEntities1 db = new QLBANGIAYEntities1())
                {
                    db.tblDangNhaps.Add(dn);
                    db.SaveChanges();
                }
                   
            }
            SetDataGridView();
            Clear();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            txtTaiKhoan.ReadOnly = false;

            Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dn.TenTaiKhoan = txtTaiKhoan.Text.Trim();
            dn.MatKhau = txtMatKhau.Text.Trim();
            dn.MaNhanVien = cmbMaNhanVien.Text;
            if(rbNhanVien.Checked == true)
            {
                dn.PhanQuyen = 2; 
            }else
            {
                dn.PhanQuyen = 1;
            }

            using (QLBANGIAYEntities1 db = new QLBANGIAYEntities1())
            {
                db.Entry(dn).State = EntityState.Modified;
                db.SaveChanges();
                SetDataGridView();
            }
              
            Clear();
            btnLuu.Enabled = true;

            MessageBox.Show("Bạn đã sửa thông tin thành công!!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QLBANGIAYEntities1 db = new QLBANGIAYEntities1())
                {
                    db.Entry(dn).State = EntityState.Modified;
                    db.tblDangNhaps.Remove(dn);
                    db.SaveChanges();
                    SetDataGridView();
                }
                    
                Clear();
                btnLuu.Enabled = true;
                txtTaiKhoan.ReadOnly = false;


            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities1 db = new QLBANGIAYEntities1())
            {

                var tk = db.tblDangNhaps.Where(p => p.TenTaiKhoan.Equals(cmbTimKiem.Text)).FirstOrDefault();
                if (tk != null)
                {
                    dgvTaiKhoan.DataSource = db.tblDangNhaps.Where(p => p.TenTaiKhoan.Contains(tk.TenTaiKhoan)).Select(p => new
                    {
                        p.TenTaiKhoan,
                        p.MatKhau
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbMaNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTenNhanVien.Text = cmbMaNhanVien.SelectedValue.ToString();
        }

    }
}
