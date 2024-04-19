
namespace BanGiay
{
    partial class frmThuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuNhap));
            this.label2 = new System.Windows.Forms.Label();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.dateNgayThang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.dgvDanhThu = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày:";
            // 
            // dateBatDau
            // 
            this.dateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBatDau.Location = new System.Drawing.Point(194, 132);
            this.dateBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(256, 34);
            this.dateBatDau.TabIndex = 1;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateKetThuc.Location = new System.Drawing.Point(637, 130);
            this.dateKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(305, 34);
            this.dateKetThuc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày: ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(979, 128);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(223, 46);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.dateNgayThang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenFile);
            this.groupBox2.Controls.Add(this.btnXuatExcel);
            this.groupBox2.Controls.Add(this.dgvDanhThu);
            this.groupBox2.Controls.Add(this.btnThongKe);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateKetThuc);
            this.groupBox2.Controls.Add(this.dateBatDau);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1210, 607);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu  bảng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.OldLace;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1002, 543);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(200, 46);
            this.btnDong.TabIndex = 54;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dateNgayThang
            // 
            this.dateNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayThang.Location = new System.Drawing.Point(29, 563);
            this.dateNgayThang.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayThang.Name = "dateNgayThang";
            this.dateNgayThang.Size = new System.Drawing.Size(251, 34);
            this.dateNgayThang.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 552);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tên file";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(2, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1200, 82);
            this.button4.TabIndex = 51;
            this.button4.Text = "Thống Kê Thu Nhập";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(137, 527);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(150, 24);
            this.lblTongTien.TabIndex = 48;
            this.lblTongTien.Text = "............................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(22, 527);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Thu nhập : ";
            // 
            // txtTenFile
            // 
            this.txtTenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFile.Location = new System.Drawing.Point(479, 544);
            this.txtTenFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenFile.Multiline = true;
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(232, 45);
            this.txtTenFile.TabIndex = 46;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.OldLace;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(753, 544);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(223, 46);
            this.btnXuatExcel.TabIndex = 45;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // dgvDanhThu
            // 
            this.dgvDanhThu.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvDanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colMaSanPham,
            this.colTenSanPham,
            this.colMaNhanVien,
            this.colThanhTien});
            this.dgvDanhThu.Location = new System.Drawing.Point(8, 193);
            this.dgvDanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhThu.Name = "dgvDanhThu";
            this.dgvDanhThu.RowHeadersWidth = 51;
            this.dgvDanhThu.Size = new System.Drawing.Size(1194, 320);
            this.dgvDanhThu.TabIndex = 35;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaHoaDon.DataPropertyName = "MaHoaDon";
            this.colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.colMaHoaDon.MinimumWidth = 6;
            this.colMaHoaDon.Name = "colMaHoaDon";
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.colMaSanPham.MinimumWidth = 6;
            this.colMaSanPham.Name = "colMaSanPham";
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.MinimumWidth = 6;
            this.colTenSanPham.Name = "colTenSanPham";
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Mã Nhân Viên";
            this.colMaNhanVien.MinimumWidth = 6;
            this.colMaNhanVien.Name = "colMaNhanVien";
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // frmThuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1236, 633);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmThuNhap";
            this.Text = "frmThuNhap";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvDanhThu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNgayThang;
        private System.Windows.Forms.Button btnDong;
    }
}