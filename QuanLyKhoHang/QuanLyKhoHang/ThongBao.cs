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
    public partial class ThongBao : Form
    {
        dbAccess database = new dbAccess();
        functionShare funcShare;
        public ThongBao()
        {
            InitializeComponent();
            database.pickSever(1);
            funcShare = new functionShare(1);
        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)//not header           
            {
                PhieuNhap pn = new PhieuNhap();
                this.Controls.Clear();
                pn.TopLevel = false;
                this.Controls.Add(pn);
                pn.Dock = DockStyle.Fill;
                pn.Show();
            }
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {

            string query = "SELECT *FROM ListRunOut ORDER BY tinh_trang";
            database.pushGridview(query, gridView);
        }
    }
}
