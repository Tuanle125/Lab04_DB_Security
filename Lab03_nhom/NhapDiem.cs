using Lab03_nhom.Link_DBSQL;
using Lab03_nhom.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Lab03_nhom
{
    public partial class NhapDiem : Form
    {
        SqlConnection sqlconn = null;
        SqlCommand cmd;
        public static String MANV, MALOP;

        private static ArrayList ListMASV = new ArrayList();
        private static ArrayList ListHOTEN = new ArrayList();
        private static ArrayList ListDIEM = new ArrayList();

        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

        public NhapDiem(String maNV, String maLop)
        {
            InitializeComponent();
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(DB.strConn);
            }
            MANV = maNV;
            MALOP = maLop;
        }
        private void QLDIEM_Click(object sender, EventArgs e)
        {
            TBdiem.Text = "";
            TBmaSV.Text = "";
            TBtenSV.Text = "";

            TBmaSV.ReadOnly = true;
            TBtenSV.ReadOnly = true;
        }

        private void QLDIEM_Load(object sender, EventArgs e)
        {
            frm_load();
        }
        private void frm_load()
        {
            CBTenLop.DisplayMember = "TENLOP";
            CBTenLop.DataSource = FetchNameLOP();

            TBmaSV.ReadOnly = true;
            TBtenSV.ReadOnly = true;
            dataGridViewSV_List();
        }
        private void dataGridViewSV_List()
        {
            FetchNhapDiem();
        }
        private DataTable FetchNameLOP()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_NAME_LOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MANV", SqlDbType.VarChar, 20).Value = MANV;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        private void FetchNhapDiem()
        {
            RSACryptoServiceProvider rsa1 = new RSACryptoServiceProvider();

            cmd = new SqlCommand("SP_SEL_PRIKEY_NV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MANV", SqlDbType.VarChar, 20).Value = MANV;
            SqlDataReader kq = cmd.ExecuteReader();
            if (kq.Read())
            {
                string priKey = kq[0].ToString();
                rsa1.FromXmlString(priKey);
            }

            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_DIEM", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 20).Value = MALOP;
            cmd.Parameters.Add("MANV", SqlDbType.VarChar, 20).Value = MANV;

            SqlDataReader ds = cmd.ExecuteReader();

            while (ds.Read())
            {
                try
                {
                    ListMASV.Add(ds["MASV"].ToString());
                    ListHOTEN.Add(ds["HOTEN"].ToString());
                    byte[] DIEM = (byte[])ds["DIEMTHI"];
                    byte[] dencryptedtext = RSADecrypt(DIEM, rsa1.ExportParameters(true));
                    string DiemThi = Encrypt.Encrypt.ConvertByteToHexa(dencryptedtext);
                    ListDIEM.Add(DiemThi[1]);
                }
                catch
                {
                    ListDIEM.Add("0");
                }
            }
            dataGridViewDiem.Rows.Clear();
            for (int i = 0; i < ListMASV.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridViewDiem);
                newRow.Cells[0].Value = ListMASV[i];
                newRow.Cells[1].Value = ListHOTEN[i];
                newRow.Cells[2].Value = ListDIEM[i];
                dataGridViewDiem.Rows.Add(newRow);
            }
            ListMASV.Clear(); ListHOTEN.Clear(); ListDIEM.Clear();
        }
        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            String diem = TBdiem.Text.Trim();
            String maSV = TBmaSV.Text.Trim();
            if (maSV == "")
            {
                MessageBox.Show("Hãy Chọn Sinh Viên", "Thông Báo");
                return;
            }
            if (diem == "")
            {
                MessageBox.Show("Điểm Chưa Được Nhập", "Thông Báo");
                return;
            }

            cmd = new SqlCommand("SP_SEL_PUBKEY_NV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MANV", SqlDbType.VarChar, 20).Value = MANV;
            SqlDataReader kq = cmd.ExecuteReader();
            if (kq.Read())
            {
                string pubKey = kq[0].ToString();
                rsa.FromXmlString(pubKey);
            }

            byte[] diemBinary = ByteConverter.GetBytes(diem);
            byte[] diemEncrypt = RSAEncrypt(diemBinary, rsa.ExportParameters(false), false);
            
            cmd = new SqlCommand("SP_UPD_DIEM", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 20).Value = MALOP;
            cmd.Parameters.Add("MASV", SqlDbType.VarChar, 20).Value = maSV;
            cmd.Parameters.Add("DIEM", SqlDbType.VarBinary).Value = diemEncrypt; 
            cmd.ExecuteReader();
            MessageBox.Show("Cập Nhập Thành Công", "Thông Báo");
            dataGridViewSV_List();
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            TBdiem.Text = "";
            TBmaSV.Text = "";
            TBtenSV.Text = "";
        }

        private void CBTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
                var ClassName = CBTenLop.Text.Trim();
                SqlCommand cmd_check = new SqlCommand("SP_DSLOP", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd_check.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 100).Value = ClassName;
                SqlDataReader check_MLop = cmd_check.ExecuteReader();
                //MessageBox.Show("Mã lớp" + MALOP, "Thông Báo");
                if (check_MLop.Read())
                {
                    MALOP = check_MLop[0].ToString();
                    //MessageBox.Show("Mã lớp" + MALOP, "Thông Báo");
                    TBdiem.Text = "";
                    TBmaSV.Text = "";
                    TBtenSV.Text = "";
                    dataGridViewSV_List();
                }
        }

        private void dataGridViewDiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                DataGridViewRow dataGridViewRow = dataGridViewDiem.Rows[e.RowIndex];
                TBmaSV.Text = dataGridViewRow.Cells[0].Value.ToString();
                TBtenSV.Text = dataGridViewRow.Cells[1].Value.ToString();
                TBdiem.Text = dataGridViewRow.Cells[2].Value.ToString();
            }
            catch { }
        }

        private byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);

                encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
            return encryptedData;
        }

        private byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                decryptedData = RSA.Decrypt(DataToDecrypt, false);
            }
            return decryptedData;
        }
    }
}
