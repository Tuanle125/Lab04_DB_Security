using Lab03_nhom.Link_DBSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
namespace Lab03_nhom.UserControls
{
    public partial class UC_QLSV : UserControl
    { 
        SqlConnection sqlconn = null;
        SqlCommand cmd;
        public static String  MANV,MALOP;
        
        public UC_QLSV()
        {
            InitializeComponent();
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(DB.strConn);
            }
        }
        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            frm_load();
        }
        private void frm_load()
        { 
            tenLop.DisplayMember = "TENLOP";
            tenLop.DataSource = FetchNameLOP(); 
            
            TbMaSV.ReadOnly = true;
            dataGridViewSV_List();
        }
        private DataTable FetchSinhVien()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_SINHVIEN", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 20).Value = MALOP;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        private void dataGridViewSV_List()
        {
            dataGridViewSV.DataSource = FetchSinhVien();
        }
        private void dataGridViewSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewSV.Rows[e.RowIndex];
            DateTime Datetime = Convert.ToDateTime(dataGridViewRow.Cells[2].Value.ToString());
            String MaSV = dataGridViewRow.Cells[0].Value.ToString();
            String HoTen = dataGridViewRow.Cells[1].Value.ToString();
            String DiaChi = dataGridViewRow.Cells[3].Value.ToString();
            String TenDN = dataGridViewRow.Cells[4].Value.ToString();

            TbMaSV.Text = MaSV;
            TbHoTen.Text = HoTen;
            dateTimePicker1.Value = Datetime;
            TbDiaChi.Text = DiaChi;
            TbTenDN.Text = TenDN;


            TbHoTen.ReadOnly = true;
            TbDiaChi.ReadOnly = true;
            TbTenDN.ReadOnly = true;
            TbMatKhau.ReadOnly = true;
        }
        private DataTable FetchNameNV()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_NAME_NHANVIEN", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(dt);
            return dt;
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
        private void buttonNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiem fNhapDiem = new NhapDiem(MANV, MALOP);
            fNhapDiem.Show();
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            frm_load();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            TbHoTen.ReadOnly = false;
            TbDiaChi.ReadOnly = false;
            TbTenDN.ReadOnly = false;
            TbMatKhau.ReadOnly = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            String MaSV = TbMaSV.Text;
            String HoTen = TbHoTen.Text;
            String DiaChi = TbDiaChi.Text;
            String TenDN = TbTenDN.Text;
            String MatKhau = TbMatKhau.Text;
            DateTime NgaySinh = dateTimePicker1.Value;

            if (MatKhau == "")
            {
                cmd = new SqlCommand("SP_UPDATESV_NOPASSWORD", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@MASV", SqlDbType.VarChar, 50).Value = MaSV;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50).Value = HoTen;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = NgaySinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100).Value = DiaChi;
                cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 50).Value = MALOP;
                cmd.Parameters.Add("@TENDN", SqlDbType.VarChar, 50).Value = TenDN;
                cmd.ExecuteReader();
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridViewSV_List();
            }
            else
            {
                cmd = new SqlCommand("SP_UPDATESV_PASSWORD", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("MASV", SqlDbType.VarChar, 50).Value = MaSV;
                cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar, 50).Value = HoTen;
                cmd.Parameters.Add("NGAYSINH", SqlDbType.DateTime).Value = NgaySinh;
                cmd.Parameters.Add("DIACHI", SqlDbType.NVarChar, 100).Value = DiaChi;
                cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 50).Value = MALOP;
                cmd.Parameters.Add("TENDN", SqlDbType.VarChar, 50).Value = TenDN;
                cmd.Parameters.Add("MATKHAU", SqlDbType.VarChar, 50).Value = MatKhau;
                cmd.ExecuteReader();
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridViewSV_List();
            }
        }
        private int FetchSoLuongSinhVien(string Malop)
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_CNT_SV_LOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 50).Value = Malop;
            SqlDataReader kq = cmd.ExecuteReader();
            if (kq.Read())
            {
                return kq.GetInt32(0);
            }
            else
            {
                return 0;
            }
        }

        private void tenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ClassName = tenLop.Text.Trim();
            SqlCommand cmd_check = new SqlCommand("SP_DSLOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_check.Parameters.Add("@TENLOP", SqlDbType.NVarChar,100).Value = ClassName;
            SqlDataReader check_MLop = cmd_check.ExecuteReader();  
            if (check_MLop.Read())
            {
                UC_QLSV.MALOP = check_MLop[0].ToString();
                dataGridViewSV_List();
                SoluongSV.Text = FetchSoLuongSinhVien(MALOP).ToString();
                SoluongSV.ReadOnly = true;
            }
        }

        private void UC_QLSV_MouseClick(object sender, MouseEventArgs e)
        {
            TbHoTen.ReadOnly = false;
            TbDiaChi.ReadOnly = false;
            TbTenDN.ReadOnly = false;
            TbMatKhau.ReadOnly = false;
            TbMaSV.ReadOnly = false;

            TbMaSV.Text = "";
            TbHoTen.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            TbDiaChi.Text = "";
            TbTenDN.Text = "";
            TbMatKhau.Text = "";
        }

    }
    
}
