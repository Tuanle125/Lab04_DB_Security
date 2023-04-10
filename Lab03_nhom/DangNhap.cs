using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lab03_nhom.UserControls;
using Lab03_nhom.Link_DBSQL;
using Lab03_nhom.Encrypt;
using System.Security.Cryptography;

namespace Lab03_nhom
{
    public partial class DangNhap : Form
    {
        SqlConnection sqlconn = null;
        SqlCommand cmd;
        public DangNhap()
        {
            InitializeComponent();
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(DB.strConn);
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            var TaiKhoan = textBoxTaiKhoan.Text.Trim();
            string MatKhau = textBoxMatKhau.Text.Trim();
            byte[] MHMatKhau = Encrypt.Encrypt.CreateSHA(MatKhau);
            cmd = new SqlCommand("SP_CHECK_NHANVIEN_PASSWORD", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TaiKhoan;
            cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary).Value = MHMatKhau;
            SqlDataReader kq = cmd.ExecuteReader();
            if (kq.Read())
            {
                UC_QLSV.MANV = kq[1].ToString();
                Form1 frmManagerStudent = new Form1();
                //= new frmManagerClass(MANV, MatKhau); 
                this.Hide();
                frmManagerStudent.ShowDialog();
                frmManagerStudent = null;
                this.Show();
                textBoxTaiKhoan.Text = "";
                textBoxMatKhau.Text = "";
            }
            else
            {
                MHMatKhau = Encrypt.Encrypt.CreateMD5(MatKhau);
                cmd = new SqlCommand("SP_CHECK_SINHVIEN", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TaiKhoan;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary).Value = MHMatKhau;
                kq = cmd.ExecuteReader();
                if (kq.Read())
                {
                    MessageBox.Show("Chào bạn sinh viên " + kq[1].ToString());

                }
                else
                {
                    MessageBox.Show("tên đăng nhập và mật khẩu kh đúng");
                }
            } 
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

    }
}
