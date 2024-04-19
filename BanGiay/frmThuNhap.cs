using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.DAL;
using BanGiay.Model;
using app = Microsoft.Office.Interop.Excel.Application;

namespace BanGiay
{
    public partial class frmThuNhap : Form
    {
        GetDanhSachDAL ds;

        public frmThuNhap()
        {
            ds = new GetDanhSachDAL(); 
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var dt = ds.GetDanhThu(dateBatDau.Value, dateKetThuc.Value);
            dgvDanhThu.DataSource = dt; 
            float tongtien = 0;
           for(int i = 0; i< dgvDanhThu.Rows.Count; i++)
            {
                tongtien += float.Parse(dgvDanhThu.Rows[i].Cells[4].Value.ToString());
            }
            lblTongTien.Text = tongtien.ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat);
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
                DataGridView g = dgvDanhThu;
                string ngaythang = dateNgayThang.Value.ToString();
                string tenbang = "THÔNG TIN THU NHẬP";
                string tenfile = txtTenFile.Text.Trim();
                string duongdan = @"C:\Users\eTivL\OneDrive\Desktop\CongNghePhanMem\BaoCaoCuoiKi\BanGiay";
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                obj.Range["A1:Z100"].Style.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                for (int i = 1; i < g.Columns.Count + 1; i++)
                {
                    obj.Cells[6, i] = g.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < g.Rows.Count; i++)
                    for (int j = 0; j < g.Columns.Count; j++)
                    {
                        if (g.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 7, j + 1] = g.Rows[i].Cells[j].Value;
                            

                        }


                    }

                obj.Range["A1:Z100"].ColumnWidth = 25;
                obj.Range["A1:z2"].Font.Size = 16;
                obj.Range["A6:z6"].Font.Size = 15;
                obj.Range["A1:Z100"].Font.Name = "Times new roman";
                obj.Range["A1:B3"].Font.Bold = true;
                obj.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
                obj.Range["B1:B100"].ColumnWidth = 20;
                obj.Range["A1:B1"].MergeCells = true;
                obj.Range["C3:D3"].MergeCells = true;
                obj.Range["A2:B2"].MergeCells = true;
                obj.Range["D1:E1"].MergeCells = true;
                obj.Range["A1:B1"].Value = "Shop giầy VNT";
                obj.Range["D1:E1"].Value = "Thời gian : " + ngaythang;
                obj.Range["A2:B2"].Value = "Quận Bình Thạnh -- TP.HCM";
                obj.Range["C3:D3"].Value = tenbang.Trim();
                obj.Range["D14:D14"].Value = "Tổng tiền:";
                obj.Range["E14:E14"].Value = lblTongTien.Text;
                obj.Range["E14:E14"].Font.Size = 16;
                obj.Range["D14:D14"].Font.Size = 16;


                obj.Range["C3:D3"].Font.Size = 16;

                obj.Range["A2:B2"].Font.ColorIndex = 5;
                obj.Range["B2:D2"].Font.ColorIndex = 3;
                obj.Range["C3:D3"].Font.ColorIndex = 3;

                obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                string mofile = duongdan + tenfile + ".xlsx";
                Process.Start(@"" + mofile);

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
