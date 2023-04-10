using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Lab03_nhom.Link_DBSQL;

namespace Lab03_nhom.UserControls
{
    public partial class UC_QLNV : UserControl
    {
        SqlConnection sqlconn = null;
        SqlCommand cmd;
        public UC_QLNV()
        {
            InitializeComponent();
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(DB.strConn);
            }
        }
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;

        private void UC_QLNV_Load(object sender, EventArgs e)
        {
            dataGridViewQLNV_data();
             
        }
        private void UC_QLNV_Click(object sender, EventArgs e)
        {
            TbMaNV.Text = "";
            TbLuong.ReadOnly = false;
            TbMK.ReadOnly = false;
        }
        private void dataGridViewQLNV_data()
        {
            dataGridViewNV.DataSource = FetchNV();
            
        }
        private DataTable FetchNV()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }

            cmd = new SqlCommand("SP_SEL_LISTNV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);  
            sqlDataAdapter.Fill(dt);
            
             
            return dt;

        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            var Manv = TbMaNV.Text.Trim();
            if (Manv == "")
            {
                MessageBox.Show("Hãy nhập mã nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_CHECK_NV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@MANV", SqlDbType.VarChar, 20).Value = Manv;
            SqlDataReader kq = cmd.ExecuteReader();
            if (kq.HasRows)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var Hoten = TbHT.Text.Trim();
                    var Email = TbEmail.Text.Trim();
                    var Luong = RSA.ExportParameters(false).ToString();
                    var TenDN = TbTDN.Text.Trim();
                    var Matkhau = TbMK.Text.ToString();
                    string PubKey; string PriKey;
                    byte[] bytes = Encrypt.Encrypt.CreateSHA(Matkhau);

                    // mã hoá Lương
                    plaintext = ByteConverter.GetBytes(TbLuong.Text);
                    PubKey = RSA.ToXmlString(false);
                    PriKey = RSA.ToXmlString(true);
                    encryptedtext = Encrypt.Encrypt.RSAEncrypt(plaintext, RSA.ExportParameters(false), false);

                    cmd = new SqlCommand("SP_INS_PUBLIC_ENCRYPT_NHANVIEN", sqlconn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("MANV", SqlDbType.VarChar, 30).Value = Manv;
                    cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar, 50).Value = Hoten;
                    cmd.Parameters.Add("EMAIL", SqlDbType.VarChar, 50).Value = Email;
                    cmd.Parameters.Add("LUONG", SqlDbType.VarBinary).Value = encryptedtext;
                    cmd.Parameters.Add("TENDN", SqlDbType.VarChar).Value = TenDN;
                    cmd.Parameters.Add("MATKHAU", SqlDbType.VarBinary).Value = bytes;
                    cmd.Parameters.Add("PUBKEY", SqlDbType.VarChar).Value = PubKey;
                    cmd.Parameters.Add("PRIKEY", SqlDbType.VarChar).Value = PriKey; 
                    cmd.ExecuteReader();
                    dataGridViewQLNV_data();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow dataGridViewRow = dataGridViewNV.Rows[e.RowIndex];
            TbMaNV.Text = dataGridViewRow.Cells[0].Value.ToString();
            TbHT.Text = dataGridViewRow.Cells[1].Value.ToString();
            TbEmail.Text = dataGridViewRow.Cells[2].Value.ToString();
            TbTDN.Text = dataGridViewRow.Cells[3].Value.ToString();
            TbLuong.ReadOnly = true;
            TbMK.ReadOnly= true;
            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang bảo tri", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            var MaNV = TbMaNV.Text.Trim();
            if (MaNV == "")
            {
                MessageBox.Show("Hãy nhập mã nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            cmd = new SqlCommand("SP_CHECK_NV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@MANV", SqlDbType.VarChar, 20).Value = MaNV;
            SqlDataReader kq = cmd.ExecuteReader();
            if (!kq.HasRows)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                { 
                var HoTen = TbHT.Text.Trim();
                var Email = TbEmail.Text.Trim();
                var TenDN = TbTDN.Text.Trim();
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                }
                cmd = new SqlCommand("SP_UPDATE_NV", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar, 20).Value = MaNV;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 100).Value = HoTen;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 100).Value = Email;
                cmd.Parameters.Add("@TENDN", SqlDbType.VarChar, 100).Value = TenDN;
                cmd.ExecuteReader();
                MessageBox.Show("Lưu Thành Công", "Thông Báo");
                dataGridViewQLNV_data();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
