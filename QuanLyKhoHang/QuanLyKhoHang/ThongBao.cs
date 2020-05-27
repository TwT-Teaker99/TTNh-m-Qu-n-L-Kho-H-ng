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
        public ThongBao()
        {
            InitializeComponent();
            
        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            this.Controls.Clear();
             pn.TopLevel = false;
            this.Controls.Add(pn);
            pn.Dock = DockStyle.Fill;
            pn.Show();
        }
    }
}
