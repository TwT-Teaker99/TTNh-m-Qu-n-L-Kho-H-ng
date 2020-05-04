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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveMdiChild.Close();
            NhaCungCap formNCC = new NhaCungCap();
            formNCC.MdiParent = this;
            formNCC.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveMdiChild.Close();
            PhieuNhap formPN = new PhieuNhap();
            formPN.MdiParent = this;
            formPN.Show();
        }

        private void quầyHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveMdiChild.Close();
            QuayHang formQuay = new QuayHang();
            formQuay.MdiParent = this;
            formQuay.Show();
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveMdiChild.Close();
            PhieuTra formPT = new PhieuTra();
            formPT.MdiParent = this;
            formPT.Show();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveMdiChild.Close();
            LoaiHang formLH = new LoaiHang();
            formLH.MdiParent = this;
            formLH.Show();
        }

        private void mặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ActiveMdiChild.Close();
            MatHang formMH = new MatHang();
            formMH.MdiParent = this;
            formMH.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveMdiChild.Close();
            NhanVien formNV = new NhanVien();
            formNV.MdiParent = this;
            formNV.Show();
        }
    }
}
