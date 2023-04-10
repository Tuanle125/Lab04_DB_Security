using Lab03_nhom.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_nhom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
            buttonTrangChu.BackColor = Color.LightGray;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonTrangChu_Click(object sender, EventArgs e)
        {
            buttonTrangChu.BackColor = Color.LightGray;
            buttonQLSV.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLLH.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLNV.BackColor = Color.FromArgb(48, 51, 103);
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void buttonQLLH_Click(object sender, EventArgs e)
        {
            buttonTrangChu.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLSV.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLLH.BackColor = Color.LightGray;
            buttonQLNV.BackColor = Color.FromArgb(48, 51, 103);
            UC_QLLH uc = new UC_QLLH();
            addUserControl(uc);
        }

        private void buttonQLSV_Click(object sender, EventArgs e)
        {
            buttonTrangChu.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLLH.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLSV.BackColor = Color.LightGray;
            buttonQLNV.BackColor = Color.FromArgb(48, 51, 103);
            UC_QLSV uc = new UC_QLSV();
            addUserControl(uc);
        }
        private void buttonQLNV_Click(object sender, EventArgs e)
        {
            buttonTrangChu.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLLH.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLSV.BackColor = Color.FromArgb(48, 51, 103);
            buttonQLNV.BackColor = Color.LightGray;
            UC_QLNV uc = new UC_QLNV();
            addUserControl(uc);
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
