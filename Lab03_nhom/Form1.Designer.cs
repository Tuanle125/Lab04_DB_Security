namespace Lab03_nhom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQLNV = new System.Windows.Forms.Button();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.buttonTrangChu = new System.Windows.Forms.Button();
            this.buttonQLSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQLLH = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.buttonQLNV);
            this.panel1.Controls.Add(this.iconButtonExit);
            this.panel1.Controls.Add(this.buttonTrangChu);
            this.panel1.Controls.Add(this.buttonQLSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonQLLH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 46);
            this.panel1.TabIndex = 0;
            // 
            // buttonQLNV
            // 
            this.buttonQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.buttonQLNV.FlatAppearance.BorderSize = 0;
            this.buttonQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQLNV.ForeColor = System.Drawing.Color.White;
            this.buttonQLNV.Location = new System.Drawing.Point(623, 0);
            this.buttonQLNV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQLNV.Name = "buttonQLNV";
            this.buttonQLNV.Size = new System.Drawing.Size(152, 46);
            this.buttonQLNV.TabIndex = 4;
            this.buttonQLNV.Text = "Quản lý nhân viên";
            this.buttonQLNV.UseVisualStyleBackColor = false;
            this.buttonQLNV.Click += new System.EventHandler(this.buttonQLNV_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.Location = new System.Drawing.Point(810, 0);
            this.iconButtonExit.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(70, 46);
            this.iconButtonExit.TabIndex = 3;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // buttonTrangChu
            // 
            this.buttonTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.buttonTrangChu.FlatAppearance.BorderSize = 0;
            this.buttonTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrangChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTrangChu.ForeColor = System.Drawing.Color.White;
            this.buttonTrangChu.Location = new System.Drawing.Point(153, 0);
            this.buttonTrangChu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTrangChu.Name = "buttonTrangChu";
            this.buttonTrangChu.Size = new System.Drawing.Size(152, 46);
            this.buttonTrangChu.TabIndex = 2;
            this.buttonTrangChu.Text = "Trang chủ";
            this.buttonTrangChu.UseVisualStyleBackColor = false;
            this.buttonTrangChu.Click += new System.EventHandler(this.buttonTrangChu_Click);
            // 
            // buttonQLSV
            // 
            this.buttonQLSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.buttonQLSV.FlatAppearance.BorderSize = 0;
            this.buttonQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQLSV.ForeColor = System.Drawing.Color.White;
            this.buttonQLSV.Location = new System.Drawing.Point(467, 0);
            this.buttonQLSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQLSV.Name = "buttonQLSV";
            this.buttonQLSV.Size = new System.Drawing.Size(152, 46);
            this.buttonQLSV.TabIndex = 1;
            this.buttonQLSV.Text = "Quản lý sinh viên";
            this.buttonQLSV.UseVisualStyleBackColor = false;
            this.buttonQLSV.Click += new System.EventHandler(this.buttonQLSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOBA";
            // 
            // buttonQLLH
            // 
            this.buttonQLLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.buttonQLLH.FlatAppearance.BorderSize = 0;
            this.buttonQLLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLLH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQLLH.ForeColor = System.Drawing.Color.White;
            this.buttonQLLH.Location = new System.Drawing.Point(310, 0);
            this.buttonQLLH.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQLLH.Name = "buttonQLLH";
            this.buttonQLLH.Size = new System.Drawing.Size(152, 46);
            this.buttonQLLH.TabIndex = 0;
            this.buttonQLLH.Text = "Quản lý lớp học";
            this.buttonQLLH.UseVisualStyleBackColor = false;
            this.buttonQLLH.Click += new System.EventHandler(this.buttonQLLH_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 46);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(880, 438);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 484);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonQLSV;
        private System.Windows.Forms.Button buttonQLLH;
        private System.Windows.Forms.Button buttonTrangChu;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Button buttonQLNV;
    }
}
