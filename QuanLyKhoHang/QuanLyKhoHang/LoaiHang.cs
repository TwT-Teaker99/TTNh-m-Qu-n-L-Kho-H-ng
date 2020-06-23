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
    public partial class LoaiHang : Form
    {
        dbAccess db = new dbAccess();
        functionShare funcShare;
        SqlCommand cmd;
        private bool isFormRegister = true;
        string c1, c2;
        public LoaiHang()
        {
            InitializeComponent();
            funcShare = new functionShare(1);
        }

        private void LoaiHang_Load(object sender, EventArgs e)
        {
            funcShare.loadGridView("loai_hang", dataGridView2);
            funcShare.autoID(label_id, "loai_hang");
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

        private void but_search_Click(object sender, EventArgs e)
        {
            if (textbox_search.Text != "")
            {
                string inputSearch = textbox_search.Text;
                string root = "select * from loai_hang WHERE ";
                string or = " OR ";
                string searchTen="";
                if (isNumber(inputSearch))
                {
                    string searchID = "id= " + inputSearch;
                    searchTen = "ten like N'%" + inputSearch + "%'";
                    root = root + searchID + or + searchTen;
                }
                else
                {
                    searchTen = "ten LIKE N'%" + inputSearch + "%'";
                    root = root + searchTen;
                }
                dbAccess.GetData(root, dataGridView2);
            }
            else
            {
                dbAccess.GetData("select * from loai_hang", dataGridView2);
            }
        }
        private void resetError()
        {
            but_error_ten.Visible = false;
        }
        private void resetRegister()
        {
            tbTen.Clear();
        }
        private bool kiemTraInput()
        {
            bool check = true;
            resetError();
            if (tbTen.Text == "")
            {
                but_error_ten.Visible = true; check = false;
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
        }
        private void but_register_Click(object sender, EventArgs e)
        {
            if (kiemTraInput())
            {
                 c1 = label_id.Text;
                 c2 = funcShare.Nvarchar(tbTen.Text);

                string query = "SET IDENTITY_INSERT loai_hang ON;" +
                "INSERT INTO loai_hang ( id,ten ) VALUES (" + c1 + "," + c2 + ")"+ "SET IDENTITY_INSERT loai_hang OFF;";
                cmd = new SqlCommand(query);
                db.editDB(cmd);
                funcShare.loadGridView("loai_hang", dataGridView2);
                funcShare.autoID(label_id, "loai_hang");
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
                funcShare.autoID(label_id, "loai_hang");
                label_sua.Visible = false;
                label_dk.Visible = true;
                but_register.Visible = true;
                but_sua.Visible = false;
                but_xoa.Visible = false;
                but_changeToRegis.Visible = false;
                isFormRegister = true;
                tbTen.Clear();
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
                        c2 = label_id.Text;
                        string query = "update loai_hang set ten=" + c1 + "where id= " + c2;
                        cmd = new SqlCommand(query);
                        db.editDB(cmd);
                        funcShare.loadGridView("loai_hang", dataGridView2);
                        changeToFormRegister();
                    }
                    break;
                case "but_xoa":

                    string delete = "DELETE FROM loai_hang WHERE id =" + label_id.Text;
                    cmd = new SqlCommand(delete);
                    db.editDB(cmd);
                    funcShare.loadGridView("loai_hang", dataGridView2);
                    changeToFormRegister();

                    break;

                case "but_changeToRegis":
                    changeToFormRegister();
                    break;

            }
        }
    }
}
