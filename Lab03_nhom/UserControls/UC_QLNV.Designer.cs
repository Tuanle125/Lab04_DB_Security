namespace Lab03_nhom.UserControls
{
    partial class UC_QLNV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMaNV = new System.Windows.Forms.Label();
            this.labelHTNV = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelTDN = new System.Windows.Forms.Label();
            this.labelMK = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.TbMaNV = new System.Windows.Forms.TextBox();
            this.TbHT = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbLuong = new System.Windows.Forms.TextBox();
            this.TbTDN = new System.Windows.Forms.TextBox();
            this.TbMK = new System.Windows.Forms.TextBox();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(53, 25);
            this.labelMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(46, 15);
            this.labelMaNV.TabIndex = 0;
            this.labelMaNV.Text = "Mã NV:";
            // 
            // labelHTNV
            // 
            this.labelHTNV.AutoSize = true;
            this.labelHTNV.Location = new System.Drawing.Point(53, 70);
            this.labelHTNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHTNV.Name = "labelHTNV";
            this.labelHTNV.Size = new System.Drawing.Size(46, 15);
            this.labelHTNV.TabIndex = 1;
            this.labelHTNV.Text = "Họ tên:";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(53, 113);
            this.labelE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(39, 15);
            this.labelE.TabIndex = 2;
            this.labelE.Text = "Email:";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(325, 25);
            this.labelL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(44, 15);
            this.labelL.TabIndex = 3;
            this.labelL.Text = "Lương:";
            // 
            // labelTDN
            // 
            this.labelTDN.AutoSize = true;
            this.labelTDN.Location = new System.Drawing.Point(325, 70);
            this.labelTDN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTDN.Name = "labelTDN";
            this.labelTDN.Size = new System.Drawing.Size(88, 15);
            this.labelTDN.TabIndex = 4;
            this.labelTDN.Text = "Tên đăng nhập:";
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Location = new System.Drawing.Point(325, 113);
            this.labelMK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(60, 15);
            this.labelMK.TabIndex = 5;
            this.labelMK.Text = "Mật khẩu:";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(654, 25);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(118, 25);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // TbMaNV
            // 
            this.TbMaNV.Location = new System.Drawing.Point(157, 24);
            this.TbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.TbMaNV.Name = "TbMaNV";
            this.TbMaNV.Size = new System.Drawing.Size(159, 23);
            this.TbMaNV.TabIndex = 7;
            // 
            // TbHT
            // 
            this.TbHT.Location = new System.Drawing.Point(157, 70);
            this.TbHT.Name = "TbHT";
            this.TbHT.Size = new System.Drawing.Size(159, 23);
            this.TbHT.TabIndex = 8;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(157, 108);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(159, 23);
            this.TbEmail.TabIndex = 9;
            // 
            // TbLuong
            // 
            this.TbLuong.Location = new System.Drawing.Point(420, 24);
            this.TbLuong.Name = "TbLuong";
            this.TbLuong.Size = new System.Drawing.Size(159, 23);
            this.TbLuong.TabIndex = 10;
            // 
            // TbTDN
            // 
            this.TbTDN.Location = new System.Drawing.Point(420, 70);
            this.TbTDN.Name = "TbTDN";
            this.TbTDN.Size = new System.Drawing.Size(159, 23);
            this.TbTDN.TabIndex = 11;
            // 
            // TbMK
            // 
            this.TbMK.Location = new System.Drawing.Point(420, 108);
            this.TbMK.Name = "TbMK";
            this.TbMK.Size = new System.Drawing.Size(159, 23);
            this.TbMK.TabIndex = 12;
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.Email,
            this.TenDangNhap});
            this.dataGridViewNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewNV.Location = new System.Drawing.Point(0, 165);
            this.dataGridViewNV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.RowTemplate.Height = 32;
            this.dataGridViewNV.Size = new System.Drawing.Size(880, 273);
            this.dataGridViewNV.TabIndex = 13;
            this.dataGridViewNV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNV_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MANV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HOTEN";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TENDN";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(654, 70);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(118, 25);
            this.buttonSua.TabIndex = 14;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(654, 108);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(118, 25);
            this.buttonXoa.TabIndex = 15;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // UC_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.dataGridViewNV);
            this.Controls.Add(this.TbMK);
            this.Controls.Add(this.TbTDN);
            this.Controls.Add(this.TbLuong);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbHT);
            this.Controls.Add(this.TbMaNV);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.labelMK);
            this.Controls.Add(this.labelTDN);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelHTNV);
            this.Controls.Add(this.labelMaNV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_QLNV";
            this.Size = new System.Drawing.Size(880, 438);
            this.Load += new System.EventHandler(this.UC_QLNV_Load);
            this.Click += new System.EventHandler(this.UC_QLNV_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label labelHTNV;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelTDN;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox TbMaNV;
        private System.Windows.Forms.TextBox TbHT;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbLuong;
        private System.Windows.Forms.TextBox TbTDN;
        private System.Windows.Forms.TextBox TbMK;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
    }
}
