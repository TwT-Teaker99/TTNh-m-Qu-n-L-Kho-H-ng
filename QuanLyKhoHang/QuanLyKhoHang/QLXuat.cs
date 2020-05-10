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
            form.Id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.Date = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.Quay = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.NV = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.Show();
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
<<<<<<< HEAD
                db.editDB(cmd);
                QLXuat_Load(sender, e);
=======
               // db.executeQuery(cmd);
>>>>>>> 3dc7f675dd5eba66d31d4903186965b5f02227ee
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
                    query = "SELECT * FROM phieu_xuat where id = '" + keySeach.ToString() + "'" +
                    "or quay_id = '" + keySeach.ToString() + "' or nhan_vien_id='" + keySeach.ToString() + "'";
                }
                else
                {
                    query = "SELECT * FROM mat_hang ";
                }
<<<<<<< HEAD
                dbAccess.GetData(query, dataGridView1);
=======
               // db.GetData(query, dataGridView1, table);

>>>>>>> 3dc7f675dd5eba66d31d4903186965b5f02227ee
            }
        }
    }
}
