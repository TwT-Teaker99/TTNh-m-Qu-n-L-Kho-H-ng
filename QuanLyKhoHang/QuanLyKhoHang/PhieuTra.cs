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
        private void LoaddataGridView()
        {
            string query = "exec proc_CHITIETPXUAT '" + tbMaPhieu.Text + "'";
            dbAccess.GetData(query, dataGridView1);
        }
        private void PhieuTra_Load(object sender, EventArgs e)
        {
            loadcomboBox();
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
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
            if(cbTenHang.Text=="")
            {
                MessageBox.Show("Bạn phải nhập mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenHang.Focus();
                return;
            }
            if(tbSL.Text.Trim().Length==0 || tbSL.Text=="0")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSL.Text = "";
                tbSL.Focus();
                return;
            }
            query = "select * from chi_tiet_phieu_xuat where phieu_xuat_id='" + tbMaPhieu.Text + "'and mat_hang_id='" + cbTenHang.SelectedValue + "'";
            if(dbAccess.CheckKey(query))
            {
                MessageBox.Show("Mặt hàng này đã này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenHang.Focus();
                return;
            }
            query = "exec proc_addCTPX '" + tbMaPhieu.Text + "','" + cbTenHang.SelectedValue + "','" + Convert.ToInt32(tbSL.Text) + "'";
            dbAccess.GetData(query, dataGridView1);
            LoaddataGridView();
        }
    }
}
