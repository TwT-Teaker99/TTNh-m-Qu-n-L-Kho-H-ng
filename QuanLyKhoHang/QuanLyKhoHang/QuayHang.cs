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
        functionShare funcShare;
        SqlCommand cmd;
        private string c1;
        private string c2;
        private string c3;
        private string c4;
        private bool isFormRegister = true;
        public QuayHang()
        {
            InitializeComponent();
            funcShare = new functionShare(3);
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
            funcShare.loadGridView("quay", dataGridView2);
            funcShare.autoID(label_id, "quay");
            dbAccess.FillCombo("select id from nhan_vien", cbMaNhanVien, "id", "id");
            cbMaNhanVien.SelectedIndex = -1;
            cbBox_Suggest(cbMaNhanVien, "select distinct id from nhan_vien");
        }

        //tạo gợi ý nhập cho cb-box
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
            if (textbox_search.Text != "")
            {
                string inputSearch = textbox_search.Text;
                string root = "select * from quay WHERE ";
                string or = " OR ";
                string searchTen;
                if (isNumber(inputSearch))
                {
                    string searchID = "id= " + inputSearch;
                    string searchMNV = "nhan_vien_id= " + inputSearch;
                    searchTen = "ten like N'%" + inputSearch + "%'";
                    root = root + searchID + or + searchMNV + or + searchTen;
                }
                else
                {
                    searchTen = "ten LIKE N'%" + inputSearch + "%'";
                    root = root + searchTen;
                }
                dbAccess.GetData(root, dataGridView2);
            }
        }
        private void resetError()
        {
            but_error_ten.Visible = false;
            but_error_mnv.Visible = false;
            but_error_tennv.Visible = false;
        }
        private void resetRegister()
        {
            tbTen.Clear();
            cbMaNhanVien.Text = "";
            tbTenNV.Clear();
        }
        private bool kiemTraInput()
        {
            bool check = true;
            resetError();
            if (tbTen.Text == "")
            {
                but_error_ten.Visible = true; check = false;
            }
            if (cbMaNhanVien.Text == "")
            {
                but_error_mnv.Visible = true; check = false;
            }
            if (tbTenNV.Text == "")
            {
                but_error_tennv.Visible = true; check = false;
            }
            return check;

        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isFormRegister)
            {
                changeToFormAlter();
            }
            label_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            tbTen.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            cbMaNhanVien.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void but_register_Click(object sender, EventArgs e)
        {
            if (kiemTraInput())
            {
                c1 = label_id.Text;
                c2 = funcShare.Nvarchar(tbTen.Text);
                c3 = funcShare.Nvarchar(cbMaNhanVien.SelectedValue.ToString());

                funcShare.insert("quay", "id, ten,nhan_vien_id", c1, c2, c3);
                funcShare.loadGridView("quay", dataGridView2);
                funcShare.autoID(label_id, "quay");
                resetRegister();
            }
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
                funcShare.autoID(label_id, "quay");
                label_sua.Visible = false;
                label_dk.Visible = true;
                but_register.Visible = true;
                but_sua.Visible = false;
                but_xoa.Visible = false;
                but_changeToRegis.Visible = false;
                isFormRegister = true;
                tbTen.Clear();
                cbMaNhanVien.Text="";
                tbTenNV.Clear();
            }
        }
        private void but_sua_xoa_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            
            switch (but.Name)
            {
                case "but_sua":
                    if (kiemTraInput())
                    {

                        c1 = funcShare.Nvarchar(tbTen.Text);
                        c2 = cbMaNhanVien.SelectedValue.ToString();
                        c3 = label_id.Text;
                        string query = "update quay set ten=" + c1 + ", nhan_vien_id=" + c2 + " where id= " + c3;
                        cmd = new SqlCommand(query);
                        db.editDB(cmd);
                        funcShare.loadGridView("quay", dataGridView2);
                        changeToFormRegister();
                    }
                    break;
                case "but_xoa":
                    
                        string delete = "DELETE FROM quay WHERE id =" + label_id.Text;
                        cmd = new SqlCommand(delete);
                        db.editDB(cmd);
                        funcShare.loadGridView("quay", dataGridView2);
                        changeToFormRegister();
  
                     break;

                case "but_changeToRegis":
                    changeToFormRegister();
                    break;

            }
        }
    }
}
