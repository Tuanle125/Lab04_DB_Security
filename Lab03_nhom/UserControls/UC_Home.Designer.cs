namespace Lab03_nhom.UserControls
{
    partial class UC_Home
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(483, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm BOBA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(239, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 270);
            this.label2.TabIndex = 1;
            this.label2.Text = "NGUYỄN HUỲNH THỊ TUYẾT MY\r\n\r\nLÂM CHẤN HUY\r\n\r\nLÊ ĐÌNH ANH TUẤN\r\n\r\nNGUYỄN PHƯỚC THỊ" +
    "NH\r\n\r\nNGUYỄN ĐẠT MINH\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(657, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 270);
            this.label3.TabIndex = 2;
            this.label3.Text = "46.01.104.109\r\n\r\n46.01.104.069\r\n\r\n46.01.104.209\r\n\r\n46.01.104.176\r\n\r\n46.01.104.100" +
    "\r\n";
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1131, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
