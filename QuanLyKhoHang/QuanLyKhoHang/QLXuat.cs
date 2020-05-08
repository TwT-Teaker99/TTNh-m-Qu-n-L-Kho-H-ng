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
    public partial class QLXuat : Form
    {
        dbAccess db = new dbAccess();
        public QLXuat()
        {
            InitializeComponent();
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            PhieuTra formPT = new PhieuTra();
            formPT.TopLevel = false;
            this.Controls.Clear();
            this.Controls.Add(formPT);
            formPT.Dock = DockStyle.Fill;
            formPT.Show();
        }

        private void QLXuat_Load(object sender, EventArgs e)
        {
            string query = "select * from phieu_xuat";
            dbAccess.GetData(query, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietPhieuXuat form = new ChiTietPhieuXuat();
            form.Show();
        }
        private bool TextBoxisnull(string tb)
        {
            if (tb == "")
                return true;
            else return false;
        }
        private bool IsNumber(string pValue)
        {

            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
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
                MessageBox.Show(query);
                SqlCommand cmd = new SqlCommand(query);
                db.executeQuery(cmd);
            }
        }

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
                    query = "SELECT * FROM mat_hang where id = '" + keySeach.ToString() + "'" +
                    "or quay_id = '" + keySeach.ToString() + "' ";
                }
                else
                {
                    query = "SELECT * FROM dbo.MatHang where TenMatHang like N'%" + keySeach + "%' ";
                }
                db.GetData(query, dataGridView1, table);

            }
        }
    }
}
