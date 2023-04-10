namespace Lab03_nhom.UserControls
{
    partial class UC_QLLH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textClassId = new System.Windows.Forms.TextBox();
            this.textClassName = new System.Windows.Forms.TextBox();
            this.CBNhanVien = new System.Windows.Forms.ComboBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.dataGridViewQLLH = new System.Windows.Forms.DataGridView();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên:";
            // 
            // textClassId
            // 
            this.textClassId.Location = new System.Drawing.Point(96, 18);
            this.textClassId.Margin = new System.Windows.Forms.Padding(2);
            this.textClassId.Name = "textClassId";
            this.textClassId.Size = new System.Drawing.Size(180, 23);
            this.textClassId.TabIndex = 3;
            // 
            // textClassName
            // 
            this.textClassName.Location = new System.Drawing.Point(359, 18);
            this.textClassName.Margin = new System.Windows.Forms.Padding(2);
            this.textClassName.Name = "textClassName";
            this.textClassName.Size = new System.Drawing.Size(180, 23);
            this.textClassName.TabIndex = 4;
            // 
            // CBNhanVien
            // 
            this.CBNhanVien.FormattingEnabled = true;
            this.CBNhanVien.Location = new System.Drawing.Point(643, 20);
            this.CBNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.CBNhanVien.Name = "CBNhanVien";
            this.CBNhanVien.Size = new System.Drawing.Size(198, 23);
            this.CBNhanVien.TabIndex = 5;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(46, 53);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(73, 25);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(173, 53);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(73, 25);
            this.buttonSua.TabIndex = 7;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(643, 53);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(73, 25);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.Location = new System.Drawing.Point(752, 53);
            this.buttonTaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(73, 25);
            this.buttonTaiLai.TabIndex = 10;
            this.buttonTaiLai.Text = "Tải lại";
            this.buttonTaiLai.UseVisualStyleBackColor = true;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // dataGridViewQLLH
            // 
            this.dataGridViewQLLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQLLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOP,
            this.TENLOP,
            this.HOTEN});
            this.dataGridViewQLLH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewQLLH.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewQLLH.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewQLLH.Name = "dataGridViewQLLH";
            this.dataGridViewQLLH.RowHeadersWidth = 51;
            this.dataGridViewQLLH.RowTemplate.Height = 32;
            this.dataGridViewQLLH.Size = new System.Drawing.Size(880, 338);
            this.dataGridViewQLLH.TabIndex = 11;
            this.dataGridViewQLLH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewQLLH_CellMouseClick);
            // 
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "Mã lớp";
            this.MALOP.MinimumWidth = 6;
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            // 
            // TENLOP
            // 
            this.TENLOP.DataPropertyName = "TENLOP";
            this.TENLOP.HeaderText = "Tên lớp";
            this.TENLOP.MinimumWidth = 6;
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên nhân viên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // UC_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewQLLH);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.CBNhanVien);
            this.Controls.Add(this.textClassName);
            this.Controls.Add(this.textClassId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_QLLH";
            this.Size = new System.Drawing.Size(880, 438);
            this.Load += new System.EventHandler(this.dGVSinhVien_load);
            this.Click += new System.EventHandler(this.UC_QLLH_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textClassId;
        private System.Windows.Forms.TextBox textClassName;
        private System.Windows.Forms.ComboBox CBNhanVien;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonTaiLai;
        public System.Windows.Forms.DataGridView dataGridViewQLLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
    }
}
