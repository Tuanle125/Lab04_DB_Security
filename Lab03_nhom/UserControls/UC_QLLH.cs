using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lab03_nhom.Link_DBSQL;
namespace Lab03_nhom.UserControls
{
    public partial class UC_QLLH : UserControl
    { 
        SqlConnection sqlconn = null;
        SqlCommand cmd; 
        public UC_QLLH()
        {
            InitializeComponent();
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(DB.strConn);
            }
        }
        private void dGVSinhVien_load(object sender, EventArgs e)
        { 
            dataGridViewQLLH_data();
            CBNhanVien.DisplayMember = "HOTEN";
            CBNhanVien.DataSource = FetchNameNV();
        }
        private void dataGridViewQLLH_data()
        {
            dataGridViewQLLH.DataSource = FetchLop();
        }
        private DataTable FetchLop()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_LOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);

            return dt;

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

        private void UC_QLLH_Click(object sender, EventArgs e)
        {
            textClassId.Text = "";
            textClassId.ReadOnly = false;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            var malop = textClassId.Text.Trim();
            if (malop == "")
            {
                MessageBox.Show("Hãy nhập mã lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_CHECK_LOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 20).Value = malop;
            SqlDataReader kq = cmd.ExecuteReader();
            if (!kq.HasRows)
            {
                MessageBox.Show("Mã lớp không tồn tại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var tenlop = textClassName.Text.Trim();
                    var tennv = CBNhanVien.Text.Trim();
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                    cmd = new SqlCommand("SP_UPD_LOP", sqlconn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 20).Value = malop;
                    cmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 100).Value = tenlop;
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50).Value = tennv;
                    cmd.ExecuteReader();
                    dataGridViewQLLH_data();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        { 
            dataGridViewQLLH_data();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            var malop = textClassId.Text.Trim();
            if (malop == "")
            {
                MessageBox.Show("Hãy nhập mã lớp", "Thông Báo");
                return;
            }
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_CHECK_LOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 20).Value = malop;
            SqlDataReader kq = cmd.ExecuteReader();
            if (kq.HasRows)
            {
                MessageBox.Show("Mã lớp đã tồn tại!!", "Thông Báo");
            }
            else
            {
                try
                {
                    var tenlop = textClassName.Text.Trim();
                    var tennv = CBNhanVien.Text.Trim();
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                    cmd = new SqlCommand("SP_INS_LOP", sqlconn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 20).Value = malop;
                    cmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 50).Value = tenlop;
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50).Value = tennv;
                    cmd.ExecuteNonQuery();
                    dataGridViewQLLH_data();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!!!", "Thông Báo");
                }

            }

        }
         
        private void dataGridViewQLLH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow dataGridViewRow = dataGridViewQLLH.Rows[e.RowIndex];
            textClassId.Text = dataGridViewRow.Cells[0].Value.ToString();
            textClassName.Text = dataGridViewRow.Cells[1].Value.ToString();
            textClassId.ReadOnly = true;
            CBNhanVien.Text = dataGridViewRow.Cells[2].Value.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var malop = textClassId.Text.Trim();
            String tenlop = textClassName.Text.ToString();
            if (malop == "")
            {
                MessageBox.Show("Hãy nhập mã lớp");
                return;
            }
             
            DialogResult result = MessageBox.Show("Bạn có chắc xoá lớp " + tenlop + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("SP_DEL_LOP", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 20).Value = malop;
                cmd.ExecuteReader();
                dataGridViewQLLH_data();
            }
        }
    }
}
