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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbAccess.FillCombo("select ten from mat_hang where loai_hang_id='" + cbLoaiHang.SelectedValue + "'", cbTenHang, "ten", "ten");
            cbTenHang.SelectedIndex = -1;
            cbBox_Suggest(cbTenHang, "select distinct ten from mat_hang where loai_hang_id='" + cbLoaiHang.SelectedValue + "'");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
