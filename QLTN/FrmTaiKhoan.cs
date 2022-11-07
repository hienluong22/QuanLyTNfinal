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
namespace QLTN
{
    public partial class FrmTaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        DataTable dtquyen = new DataTable();
        string sql, constr;
        int i;
        Boolean addnewflag = false;
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnFristCH_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
      
       }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (i >= 1)
            {
                i = grdData.CurrentRow.Index;
                grdData.CurrentCell = grdData[0, i - 1];
            }
            else
            {
                i = grdData.RowCount;
                grdData.CurrentCell = grdData[0, i - 2];
            }
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i <= grdData.RowCount - 2)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, 0];
            }
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 2];
            NapCT();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            sql = "Select MaTK,TenDN,Quyen,MatKhau from tblTaiKhoan order by MaTK";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();

            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc bấm Cập nhật!");
            txtMaTK.Focus();
            addnewflag = true;
            btnupdate.Enabled = true;
        }

        private void bntedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi mong muốn trên ô lưới," +
               "kết thúc bằng nút cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnupdate.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?Y/N", "Xác nhận" +
                "yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from tblTaiKhoan where MaCa='" + txtMaTK.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == false)
            {
                // Chỗ này là cập nhật sửa chữa
                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    txtMaTK.Text = grdData.Rows[i].Cells["MaTK"].Value.ToString();
                    txtTenDN.Text = grdData.Rows[i].Cells["TenDN"].Value.ToString();
                    txtMatKhau.Text = grdData.Rows[i].Cells["MatKhau"].Value.ToString();
                    comQ.Text = grdData.Rows[i].Cells["Quyen"].Value.ToString();

                    sql = "set dateformat dmy update tblTaiKhoan set " +
                        "MaTK='" + txtMaTK.Text + "'," +
                      " TenDN=N'" + txtTenDN.Text + "',MatKhau='" + txtMatKhau.Text + "',Quyen=N'" + comQ.Text + "'"
                        + " where MaTK='" + txtMaTK.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
            }
            else
            {
                //Chỗ này là cập nhật thêm mới
                addnewflag = false;
                sql = "insert into tblTaiKhoan(MaTK,TenDN,MatKhau,Quyen)" +
                    " Values ('" + txtMaTK.Text + "','" + txtTenDN.Text + "','" +
                    txtMatKhau.Text + "',N'" + comQ.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows[i].Cells["MaTK"].Value = txtMaTK.Text;
                grdData.Rows[i].Cells["TenDN"].Value = txtTenDN.Text;
                grdData.Rows[i].Cells["MatKhau"].Value = txtMatKhau.Text;
                grdData.Rows[i].Cells["Quyen"].Value = comQ.Text;
          }
            btnupdate.Enabled = false;
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-2C52VJI\\SQLEXPRESS; Initial Catalog = QLTN; Integrated Security = True;";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * from tblTaiKhoan  order by MaTK";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            sql = "select distinct  Quyen from tblTaiKhoan";
            da = new SqlDataAdapter(sql, conn);
            dtquyen.Clear();
            da.Fill(dtquyen);


            comQ.DataSource = dtquyen;
            comQ.DisplayMember = "Quyen";
            grdData.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sql = "select MaTK,TenDN,MatKhau,Quyen from tblTaiKhoan " +
             " where Quyen=N'" + comQ.Text+ "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sql = "select MaTK,TenDN,MatKhau,Quyen from tblTaiKhoan order by MaTK";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaTK.Text = grdData.Rows[i].Cells["MaTK"].Value.ToString();
            txtTenDN.Text = grdData.Rows[i].Cells["TenDN"].Value.ToString();
            txtMatKhau.Text = grdData.Rows[i].Cells["MatKhau"].Value.ToString();
        }
    }

}
