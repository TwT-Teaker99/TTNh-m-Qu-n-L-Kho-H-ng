using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class NhanVien : Form
    {
        dbAccess database = new dbAccess();
        functionShare funcShare;
        string query = "SELECT * FROM nham_vien";

        public NhanVien()
        {
            InitializeComponent();
            int sever = 3;
            database.pickSever(sever);
            funcShare = new functionShare(sever);
        }
        private void FillData()
        {


            funcShare.loadGridView("nhan_vien", gridView);

            funcShare.autoID(label_id, "nhan_vien");

        }
        private void resetError()
        {
            but_error_ten.Visible = false;
            but_error_tuoi.Visible = false;
            but_error_dc.Visible = false;
            but_error_sdt.Visible = false;
            but_error_luong.Visible = false;
        }


        private bool kiemTraInput()
        {
            bool check = true;
            resetError();
            if (textbox_ten.Text == "")
            {
                but_error_ten.Visible = true; check = false;


            }
            if (!funcShare.isNumber(textbox_sdt.Text) || textbox_sdt.Text.Length > 11 || textbox_sdt.Text.Length < 6)
            {
                but_error_sdt.Visible = true; check = false;

            }
            if (textbox_tuoi.Text == "" || !funcShare.isNumber(textbox_tuoi.Text) || Convert.ToInt16(textbox_tuoi.Text) < 1)
            {
                but_error_tuoi.Visible = true; check = false;

            }
            if (cbGioiTinh.Text != "Nam" && cbGioiTinh.Text != "Nữ")
            {
                check = false;
                // MessageBox.Show("loi gt");
            }
            if (textbox_dc.Text == "")
            {
                but_error_dc.Visible = true; check = false;
                // MessageBox.Show("loi dc");

            }
            if (textbox_luong.Text == "" || !funcShare.isNumber(textbox_luong.Text) || Convert.ToInt64(textbox_luong.Text) < 0)
            {
                but_error_luong.Visible = true; check = false;
                //  MessageBox.Show("loi luong");

            }
            return check;

        }
        private void Reset()
        {
            textbox_ten.Clear();
            textbox_sdt.Clear();
            textbox_tuoi.Clear();
            textbox_dc.Clear();
            textbox_luong.Clear();
            cbGioiTinh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraInput())
            {
                database.createConn();
                string iTemp;
                if (cbGioiTinh.Text == "Nam")
                {
                    iTemp = "1";
                }
                else
                {
                    iTemp = "0";
                }

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "ThemNV";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", label_id.Text);
                sqlCommand.Parameters.AddWithValue("@ten", textbox_ten.Text);
                sqlCommand.Parameters.AddWithValue("@tuoi", textbox_tuoi.Text);
                sqlCommand.Parameters.AddWithValue("@sex", iTemp);
                sqlCommand.Parameters.AddWithValue("@dia_chi", textbox_dc.Text);
                sqlCommand.Parameters.AddWithValue("@luong", textbox_luong.Text);
                sqlCommand.Parameters.AddWithValue("@sdt", textbox_sdt.Text);

                sqlCommand.Connection = dbAccess.connection;
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo");
                Reset();
                FillData();
            }
            else
            {
                MessageBox.Show("aaa");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            database.createConn();
            int iTemp;
            if (cbGioiTinh.Text == "Nam")
            {
                iTemp = 1;
            }
            else
            {
                iTemp = 0;
            }
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SuaNV";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", label_id.Text);
            sqlCommand.Parameters.AddWithValue("@ten", textbox_ten.Text);
            sqlCommand.Parameters.AddWithValue("@tuoi", textbox_tuoi.Text);
            sqlCommand.Parameters.AddWithValue("@sex", iTemp);
            sqlCommand.Parameters.AddWithValue("@dia_chi", iTemp);
            sqlCommand.Parameters.AddWithValue("@luong", textbox_luong.Text);
            sqlCommand.Parameters.AddWithValue("@sdt", textbox_sdt.Text);
            sqlCommand.Connection = dbAccess.connection;
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công", "Thông báo");
            Reset();
            FillData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            database.createConn();
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa nhân viên không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "XoaNV";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", label_id.Text);
                sqlCommand.Connection = dbAccess.connection;
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                Reset();
                FillData();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            database.createConn();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select *from nhan_vien where ten like @ten";
            sqlCommand.Parameters.AddWithValue("@ten", "%" + textbox_search.Text + "%");
            dbAccess.PushGridView(sqlCommand, gridView);



        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            int sever = 3;
            database.pickSever(sever);
            funcShare = new functionShare(sever);
            //dbAccess.connection.Open();
            //database.createConn();
            FillData();

        }
        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)//not header           
            {

                label_id.Text = this.gridView.CurrentRow.Cells[0].Value.ToString();
                textbox_ten.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
                textbox_tuoi.Text = this.gridView.CurrentRow.Cells[2].Value.ToString();
                cbGioiTinh.Text = this.gridView.CurrentRow.Cells[3].Value.ToString();
                textbox_dc.Text = this.gridView.CurrentRow.Cells[4].Value.ToString();
                textbox_luong.Text = this.gridView.CurrentRow.Cells[5].Value.ToString();
                textbox_sdt.Text = this.gridView.CurrentRow.Cells[6].Value.ToString();
            }
        }
    }
}
