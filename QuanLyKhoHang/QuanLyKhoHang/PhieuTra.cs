using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class PhieuTra : Form
    {
        dbAccess db = new dbAccess();
        DataTable table = new DataTable("CTPX");
        public PhieuTra()
        {
            InitializeComponent();
        }
        private void loadcomboBox()
        {
            //đổ dl vào mã quầy
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
            getIDpx();

        }
        private void ConTable()
        {
            table.Columns.Add(new DataColumn("MaHang", typeof(int)));
            table.Columns.Add(new DataColumn("TenHang", typeof(string)));
            table.Columns.Add(new DataColumn("SoLuong", typeof(int)));
        }
        //hàm gợi ý nhập comboBox
        private void cbBox_Suggest(ComboBox cb,string s)
        {
            cb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cbData = new AutoCompleteStringCollection();
            dbAccess.FillColl(cbData,s);
            cb.AutoCompleteCustomSource = cbData;
        }
        //sinh id phiếu xuất
        private void getIDpx()
        {
            string query = "select max(id) from phieu_xuat";
            string temp = dbAccess.GetFieldValues(query);
            tbMaPhieu.Text = (Convert.ToInt32(temp) + 1).ToString();
        }
        private void PhieuTra_Load(object sender, EventArgs e)
        {
            loadcomboBox();
            ConTable();
        }

        private void cbMaQuay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaQuay.Text == "")
                tbTenQuay.Text = "";
            else
            {
                string query = "select ten from quay where id= '" + cbMaQuay.SelectedValue + "'";
                tbTenQuay.Text = dbAccess.GetFieldValues(query);
            }
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaNhanVien.Text == "")
                tbTenNV.Text = "";
            else
            {
                string query = "select ten from nhan_vien where id= '" + cbMaNhanVien.SelectedValue + "'";
                tbTenNV.Text = dbAccess.GetFieldValues(query);
            }
        }
        private void cbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbAccess.FillCombo("select id,ten from mat_hang where loai_hang_id='" + cbLoaiHang.SelectedValue + "'", cbTenHang, "id", "ten");
            cbTenHang.SelectedIndex = -1;
            cbBox_Suggest(cbTenHang, "select distinct ten from mat_hang where loai_hang_id='" + cbLoaiHang.SelectedValue + "'");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Xác nhận thêm phiếu xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string query = "select * from phieu_xuat where id ='" + tbMaPhieu.Text + "'";
                if (!dbAccess.CheckKey(query))
                {
                    if (cbMaQuay.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập mã quầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbMaQuay.Focus();
                        return;
                    }
                    else if (cbMaNhanVien.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbMaNhanVien.Focus();
                        return;
                    }
                    else if (dateTimePicker.Text.Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dateTimePicker.Focus();
                        return;
                    }
                    query = "exec proc_addPX '" + cbMaQuay.Text + "','" + dateTimePicker.Value.Date + "','" + cbMaNhanVien.Text + "'";
                    dbAccess.GetData(query, dataGridView1);
                }
                foreach (DataRow row in table.Rows)
                {
                    query = "exec proc_addCTPX '" + tbMaPhieu.Text + "','" + row[0] + "','" + Convert.ToInt32(row[2]) + "'";
                    dbAccess.GetData(query, dataGridView1);
                }
                btnLamMoi_Click(sender,e);
            }
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (cbLoaiHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbLoaiHang.Focus();
                return;
            }
            if (cbTenHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenHang.Focus();
                return;
            }
            if (tbSL.Text.Trim().Length == 0 || tbSL.Text == "0")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSL.Text = "";
                tbSL.Focus();
                return;
            }
            table.Rows.Add(cbTenHang.SelectedValue, cbTenHang.Text, Convert.ToInt32(tbSL.Text));
            dataGridView1.DataSource = table;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbMaQuay.Text = "";
            cbMaNhanVien.Text = "";
            getIDpx();
            cbLoaiHang.Text = "";
            tbSL.Text = "";
            cbTenHang.Text = "";
            table.Rows.Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //string id;
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
