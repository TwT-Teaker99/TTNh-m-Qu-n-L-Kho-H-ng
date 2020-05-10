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
    public partial class PhieuNhap : Form
    {
        string query = "SELECT * FROM phieu_nhap";
        public PhieuNhap()
        {
            InitializeComponent();
        }
     

        private void textbox_Leave(object sender, EventArgs e)
        {

        }

        private void textbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
