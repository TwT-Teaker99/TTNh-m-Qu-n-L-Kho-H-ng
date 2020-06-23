using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class QLXuat : Form
    {
        dbAccess db = new dbAccess();
        functionShare funcShare;
        SqlCommand cmd;

        private bool isFormRegister = true;
        DataTable table;
        public QLXuat()
        {
            InitializeComponent();
            funcShare = new functionShare(1);
        }

        private void cbBox_Suggest(ComboBox cb, string s)
        {
            cb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cbData = new AutoCompleteStringCollection();
            dbAccess.FillColl(cbData, s);
            cb.AutoCompleteCustomSource = cbData;
        }

        //khởi tạo datatable chứa Chi tiết px
        private void ConTable()
        {
            table.Columns.Add(new DataColumn("mat_hang_id", typeof(int)));
            table.Columns.Add(new DataColumn("ten", typeof(string)));
            table.Columns.Add(new DataColumn("so_luong", typeof(int)));
        }
        private void QLXuat_Load(object sender, EventArgs e)
        {
            funcShare.loadGridView("phieu_xuat", dataGridView1);
            funcShare.autoID(label_id, "phieu_xuat");

            dbAccess.FillCombo("select id from quay", cbMaQuay, "id", "id");
            cbMaQuay.SelectedIndex = -1;
            //đổ dl vào mã Nhân viên
            dbAccess.FillCombo("select id from nhan_vien", cbMaNhanVien, "id", "id");
            cbMaNhanVien.SelectedIndex = -1;
            //đổ dl voà loại
            dbAccess.FillCombo("select id,ten from loai_hang", cbLoaiHang, "id", "ten");
            cbLoaiHang.SelectedIndex = -1;

            //gợi ý nhập mã quầy
            cbBox_Suggest(cbMaQuay, "select distinct id from quay");
            //gợi ý nhập loại hàng
            cbBox_Suggest(cbLoaiHang, "select distinct ten from loai_hang");
            //gợi ý nhập mã nhân viên
            cbBox_Suggest(cbMaNhanVien, "select distinct id from nhan_vien");

        }
        private void cbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbAccess.FillCombo("select id,ten from mat_hang where loai_hang_id='" + cbLoaiHang.SelectedValue + "'", cbTenHang, "id", "ten");
            cbTenHang.SelectedIndex = -1;
            cbBox_Suggest(cbTenHang, "select distinct ten from mat_hang where loai_hang_id='" + cbLoaiHang.SelectedValue + "'");
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows==null)
            {
                MessageBox.Show("Chọn một dòng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string s= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
                string query = "DELETE FROM phieu_xuat WHERE id = " + s;
                SqlCommand cmd = new SqlCommand(query);
                db.editDB(cmd);
                QLXuat_Load(sender, e);
            }
        }
        //btn tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keySeach = tbSearch.Text.ToString().Trim();
            if (keySeach.Equals(""))
            {
                MessageBox.Show("Nhập dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSearch.Focus();
            }
            else
            {
                int a;
                bool check = int.TryParse(keySeach, out a);
                string query;
                if (check == true)
                {
                    query = "SELECT * FROM phieu_xuat where id = '" + keySeach.ToString() + "'" +
                    "or quay_id = '" + keySeach.ToString() + "' or nhan_vien_id='" + keySeach.ToString() + "'";
                }
                else
                {
                    query = "SELECT * FROM mat_hang ";
                }
                dbAccess.GetData(query, dataGridView1);

            }
        }
        private void resetError()
        {
            but_error_manv.Visible = false;
            but_error_maquay.Visible = false;
            but_error_lhang.Visible = false;
            but_error_mhang.Visible = false;
            but_error_sl.Visible = false;
        }
        private void resetRegister()
        {
            cbMaNhanVien.SelectedIndex = -1;
            cbMaQuay.SelectedIndex = -1;
            cbLoaiHang.SelectedIndex = -1;
            cbTenHang.Text = "";
            textbox_soluong.Clear();
        }
        private bool kiemTraInput1()
        {
            bool check = true;
            resetError();
            if (cbMaQuay.Text == "")
            {
                but_error_maquay.Visible = true; check = false;
            }
            if (cbMaNhanVien.Text == "")
            {
                but_error_manv.Visible = true; check = false;

            }
            return check;
        }
        private bool kiemTraInput2()
        {
            bool check = true;
            resetError();
            if (cbLoaiHang.Text == "")
            {
                but_error_lhang.Visible = true; check = false;

            }
            if (cbTenHang.Text == "")
            {
                but_error_mhang.Visible = true; check = false;
            }
            if (textbox_soluong.Text == "")
            {
                but_error_sl.Visible = true; check = false;

            }
            return check;
        }
        private void changeToFormAlter()
        {
            if (isFormRegister)
            {
                label_sua.Visible = true;
                label_dk.Visible = false;
                but_register.Visible = false;
                but_sua.Visible = true;
                but_xoa.Visible = true;
                isFormRegister = false;
                but_changeToRegis.Visible = true;
                
            }

        }
        private void changeToFormRegister()
        {
            if (!isFormRegister)
            {
                funcShare.autoID(label_id, "phieu_xuat");
                label_sua.Visible = false;
                label_dk.Visible = true;
                but_register.Visible = true;
                but_sua.Visible = false;
                but_xoa.Visible = false;
                but_changeToRegis.Visible = false;
                isFormRegister = true;
                
                resetRegister();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isFormRegister)
            {
                changeToFormAlter();
            }
            label_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbMaQuay.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbMaNhanVien.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string query = "select mat_hang_id,ten,so_luong from chi_tiet_phieu_xuat,mat_hang where mat_hang_id=id and phieu_xuat_id='" + label_id.Text + "'";
            table = new DataTable("CTPX");
            ConTable();
            db.pushDataTable(cmd = new SqlCommand(query), table);
            dataGridView2.DataSource = table;

            // dbAccess.GetData(query, dataGridView2);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "select loai_hang.ten from loai_hang,mat_hang where mat_hang.loai_hang_id=loai_hang.id and mat_hang.id = "+dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cbLoaiHang.Text = dbAccess.GetFieldValues(query);
            cbTenHang.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textbox_soluong.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }
        private void but_add_Click(object sender, EventArgs e)
        {
            if(kiemTraInput2())
            {
                int sl = Convert.ToInt32(dbAccess.GetFieldValues("SELECT remain FROM mat_hang WHERE id = " + cbTenHang.SelectedValue));
                int slms = Convert.ToInt32(textbox_soluong.Text);
                DataRow[] result = table.Select("mat_hang_id=" + cbTenHang.SelectedValue);
                if (result.Length>0)
                {
                    foreach(DataRow row in result)
                    {
                        int slcu = Convert.ToInt32(row[2]);
                        if(sl+slcu-slms>=0)
                        {
                            row[2] = textbox_soluong.Text;
                        }
                        else
                        {
                            MessageBox.Show("Kho không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textbox_soluong.Focus();
                            return;
                        }   
                    }
                }
                else
                {
                    if(sl >= slms)
                    {
                        table.Rows.Add(cbTenHang.SelectedValue, cbTenHang.Text, slms);
                        dataGridView2.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("Kho không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textbox_soluong.Focus();
                        return;
                    } 

                }    
            }
        }
        private void but_del_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string query = "select * from chi_tiet_phieu_xuat where phieu_xuat_id=" + label_id.Text + "and mat_hang_id=" + dataGridView2.CurrentRow.Cells[0].Value.ToString();
                if(dbAccess.CheckKey(query))
                {
                    query= "delete from chi_tiet_phieu_xuat where phieu_xuat_id=" + label_id.Text + "and mat_hang_id=" + dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    cmd = new SqlCommand(query);
                    db.editDB(cmd);
                }    
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }
        private void but_register_Click(object sender, EventArgs e)
        {
            if(kiemTraInput1())
            {
                if ((MessageBox.Show("Xác nhận thêm phiếu xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string query = "SET IDENTITY_INSERT  phieu_xuat ON; INSERT INTO phieu_xuat (id,quay_id,ngay_xuat,nhan_vien_id) VALUES (" +label_id.Text+","+ cbMaQuay.Text + ",'" + dateTimePicker1.Value.Date + "'," + cbMaNhanVien.Text + ") SET IDENTITY_INSERT phieu_xuat OFF;";
                    cmd = new SqlCommand(query);
                    db.editDB(cmd);

                    foreach (DataRow row in table.Rows)
                    {
                        query = "exec proc_addCTPX '" + label_id.Text + "','" + row[0] + "','" + Convert.ToInt32(row[2]) + "'";
                        cmd = new SqlCommand(query);
                        db.editDB(cmd);
                    }
                    funcShare.loadGridView("phieu_xuat", dataGridView1);
                }
            }    
        }

        private void but_sua_xoa_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_sua":
                    if (kiemTraInput1())
                    {
                        string query = "update phieu_xuat set quay_id=" + cbMaQuay.Text + ", ngay_xuat='" + dateTimePicker1.Value.Date+"', nhan_vien_id="+cbMaNhanVien.Text + " where id= " + label_id.Text;
                        cmd = new SqlCommand(query);
                        db.editDB(cmd);
                        foreach(DataRow row in table.Rows)
                        {
                            query = "select * from chi_tiet_phieu_xuat where phieu_xuat_id=" + label_id.Text + "and mat_hang_id=" + row[0];
                            if(dbAccess.CheckKey(query))
                            {
                                query = "update chi_tiet_phieu_xuat set so_luong=" + Convert.ToInt32(row[2]) + "where phieu_xuat_id=" + label_id.Text + "and mat_hang_id=" + row[0];
                                cmd = new SqlCommand(query);
                                db.editDB(cmd);
                            }
                            else
                            {
                                query = "exec proc_addCTPX '" + label_id.Text + "','" + row[0] + "','" + Convert.ToInt32(row[2]) + "'";
                                cmd = new SqlCommand(query);
                                db.editDB(cmd);
                            }
                        }
                        table.Rows.Clear();
                        funcShare.loadGridView("phieu_xuat", dataGridView1);
                        changeToFormRegister();
                    }
                    break;
                case "but_xoa":

                    string delete = "DELETE FROM chi_tiet_phieu_xuat WHERE phieu_xuat_id =" + label_id.Text;
                    cmd = new SqlCommand(delete);
                    db.editDB(cmd);
                    delete= "DELETE FROM phieu_xuat WHERE id =" + label_id.Text;
                    cmd = new SqlCommand(delete);
                    db.editDB(cmd);

                    funcShare.loadGridView("phieu_xuat", dataGridView1);
                    changeToFormRegister();

                    break;

                case "but_changeToRegis":
                    table.Rows.Clear();
                    changeToFormRegister();
                    break;
            }
        }
    }
}
