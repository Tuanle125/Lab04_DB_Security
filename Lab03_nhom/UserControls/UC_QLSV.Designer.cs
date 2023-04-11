using System;
using System.Data.SqlClient;

namespace Lab03_nhom.UserControls
{
    partial class UC_QLSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonNhapDiem = new System.Windows.Forms.Button();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.ComboBox();
            this.TbTenDN = new System.Windows.Forms.TextBox();
            this.TbMatKhau = new System.Windows.Forms.TextBox();
            this.SoluongSV = new System.Windows.Forms.TextBox();
            this.TbHoTen = new System.Windows.Forms.TextBox();
            this.TbDiaChi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TbMaSV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã SV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Họ tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Địa chỉ:";
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(738, 54);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(118, 25);
            this.buttonSua.TabIndex = 9;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(604, 54);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(121, 25);
            this.buttonThem.TabIndex = 10;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonNhapDiem
            // 
            this.buttonNhapDiem.Location = new System.Drawing.Point(604, 95);
            this.buttonNhapDiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNhapDiem.Name = "buttonNhapDiem";
            this.buttonNhapDiem.Size = new System.Drawing.Size(118, 25);
            this.buttonNhapDiem.TabIndex = 11;
            this.buttonNhapDiem.Text = "Nhập điểm";
            this.buttonNhapDiem.UseVisualStyleBackColor = true;
            this.buttonNhapDiem.Click += new System.EventHandler(this.buttonNhapDiem_Click);
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.Location = new System.Drawing.Point(738, 95);
            this.buttonTaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(121, 25);
            this.buttonTaiLai.TabIndex = 12;
            this.buttonTaiLai.Text = "Tải lại";
            this.buttonTaiLai.UseVisualStyleBackColor = true;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi,
            this.TenDN});
            this.dataGridViewSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSV.Location = new System.Drawing.Point(0, 165);
            this.dataGridViewSV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.RowHeadersWidth = 51;
            this.dataGridViewSV.RowTemplate.Height = 32;
            this.dataGridViewSV.Size = new System.Drawing.Size(880, 273);
            this.dataGridViewSV.TabIndex = 13;
            this.dataGridViewSV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSV_CellMouseClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MASV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HOTEN";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NGAYSINH";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DIACHI";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // TenDN
            // 
            this.TenDN.DataPropertyName = "TENDN";
            this.TenDN.HeaderText = "Tên đăng nhập";
            this.TenDN.MinimumWidth = 6;
            this.TenDN.Name = "TenDN";
            // 
            // tenLop
            // 
            this.tenLop.FormattingEnabled = true;
            this.tenLop.Location = new System.Drawing.Point(157, 7);
            this.tenLop.Margin = new System.Windows.Forms.Padding(2);
            this.tenLop.Name = "tenLop";
            this.tenLop.Size = new System.Drawing.Size(159, 23);
            this.tenLop.TabIndex = 14;
            this.tenLop.SelectedIndexChanged += new System.EventHandler(this.tenLop_SelectedIndexChanged);
            // 
            // TbTenDN
            // 
            this.TbTenDN.Location = new System.Drawing.Point(157, 91);
            this.TbTenDN.Margin = new System.Windows.Forms.Padding(2);
            this.TbTenDN.Name = "TbTenDN";
            this.TbTenDN.Size = new System.Drawing.Size(159, 23);
            this.TbTenDN.TabIndex = 16;
            // 
            // TbMatKhau
            // 
            this.TbMatKhau.Location = new System.Drawing.Point(157, 136);
            this.TbMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.TbMatKhau.Name = "TbMatKhau";
            this.TbMatKhau.Size = new System.Drawing.Size(159, 23);
            this.TbMatKhau.TabIndex = 17;
            // 
            // SoluongSV
            // 
            this.SoluongSV.Location = new System.Drawing.Point(411, 4);
            this.SoluongSV.Margin = new System.Windows.Forms.Padding(2);
            this.SoluongSV.Name = "SoluongSV";
            this.SoluongSV.Size = new System.Drawing.Size(159, 23);
            this.SoluongSV.TabIndex = 18;
            // 
            // TbHoTen
            // 
            this.TbHoTen.Location = new System.Drawing.Point(411, 91);
            this.TbHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.TbHoTen.Name = "TbHoTen";
            this.TbHoTen.Size = new System.Drawing.Size(159, 23);
            this.TbHoTen.TabIndex = 19;
            // 
            // TbDiaChi
            // 
            this.TbDiaChi.Location = new System.Drawing.Point(411, 136);
            this.TbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.TbDiaChi.Name = "TbDiaChi";
            this.TbDiaChi.Size = new System.Drawing.Size(159, 23);
            this.TbDiaChi.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 53);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 23);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // TbMaSV
            // 
            this.TbMaSV.Location = new System.Drawing.Point(157, 53);
            this.TbMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaSV.Name = "TbMaSV";
            this.TbMaSV.Size = new System.Drawing.Size(159, 23);
            this.TbMaSV.TabIndex = 22;
            // 
            // UC_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbMaSV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TbDiaChi);
            this.Controls.Add(this.TbHoTen);
            this.Controls.Add(this.SoluongSV);
            this.Controls.Add(this.TbMatKhau);
            this.Controls.Add(this.TbTenDN);
            this.Controls.Add(this.tenLop);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonNhapDiem);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_QLSV";
            this.Size = new System.Drawing.Size(880, 438);
            this.Load += new System.EventHandler(this.UC_QLSV_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UC_QLSV_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonNhapDiem;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.ComboBox tenLop;
        private System.Windows.Forms.TextBox TbTenDN;
        private System.Windows.Forms.TextBox TbMatKhau;
        private System.Windows.Forms.TextBox SoluongSV;
        private System.Windows.Forms.TextBox TbHoTen;
        private System.Windows.Forms.TextBox TbDiaChi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TbMaSV;
    }
}