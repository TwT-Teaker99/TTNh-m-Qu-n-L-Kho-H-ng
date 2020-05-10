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
    public partial class QuayHang : Form
    {
        dbAccess db = new dbAccess();
        public QuayHang()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private bool isNumber(string pValue)
        {
            if (pValue == "")
            {
                return false;
            }
            else
            {
                foreach (Char c in pValue)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
        }

        private void QuayHang_Load(object sender, EventArgs e)
        {
            string query = "select * from quay";
            dbAccess.GetData(query, dataGridView1);
            dbAccess.FillCombo("select id from nhan_vien", cbMaNhanVien, "id", "id");
            cbMaNhanVien.SelectedIndex = -1;
            cbBox_Suggest(cbMaNhanVien, "select distinct id from nhan_vien");
        }
        private void cbBox_Suggest(ComboBox cb, string s)
        {
            cb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cbData = new AutoCompleteStringCollection();
            dbAccess.FillColl(cbData, s);
            cb.AutoCompleteCustomSource = cbData;
        }
        private void cbMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (cbMaNhanVien.Text == "")
                tbTenNV.Text = "";
            else
            {
                tbTenNV.Text = dbAccess.GetFieldValues("select ten from nhan_vien where id=" + cbMaNhanVien.Text);
            }
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            if(textbox_search.Text!="")
            {
                string inputSearch = textbox_search.Text;
                string root = "select * from quay WHERE ";
                string or = " OR ";
                string searchTen;
                if (isNumber(inputSearch))
                {
                    string searchID = "id= " + inputSearch;
                    string searchMNV = "nhan_vien_id= " + inputSearch;
                    root = root + searchID + or + searchMNV;
                }
                else
                {
                    searchTen = "ten LIKE N'%" + inputSearch + "%'";
                    root = root + searchTen;
                }
                dbAccess.GetData(root, dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbMaNhanVien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            label_id.Text = "";
            tbTen.Text = "";
            cbMaNhanVien.Text = "";
            tbTenNV.Text = "";
            string query = "select * from quay";
            dbAccess.GetData(query, dataGridView1);
        }

        private void but_register_Click(object sender, EventArgs e)
        {
            string s = "insert into quay(ten,nhan_vien_id) values (N'" + tbTen.Text + "'," + cbMaNhanVien.SelectedValue + ")";
            SqlCommand cmd = new SqlCommand(s);
            db.editDB(cmd);
            string query = "select * from quay";
            dbAccess.GetData(query, dataGridView1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Chọn một dòng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string s = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string query = "DELETE FROM quay WHERE id = " + s;
                SqlCommand cmd = new SqlCommand(query);
                db.editDB(cmd);
                query = "select * from quay";
                dbAccess.GetData(query, dataGridView1);
            }
        }
    }
}
