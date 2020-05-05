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
        //NhaCungCap formNCC = new NhaCungCap();
        //PhieuNhap formPN = new PhieuNhap();
        //QuayHang formQuay = new QuayHang();
        //PhieuTra formPT = new PhieuTra();
        //LoaiHang formLH = new LoaiHang();
        //MatHang formMH = new MatHang();
        //NhanVien formNV = new NhanVien();
        private void Main_Load(object sender, EventArgs e)
        {
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap formNCC = new NhaCungCap();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            formNCC.MdiParent = this;
            formNCC.Dock = DockStyle.Fill;
            formNCC.Show();

        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhap formPN = new PhieuNhap();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            formPN.MdiParent = this;
            formPN.Dock = DockStyle.Fill;
            formPN.Show();

        }

        private void quầyHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuayHang formQuay = new QuayHang();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            formQuay.MdiParent = this;
            formQuay.Dock = DockStyle.Fill;
            formQuay.Show();
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuTra formPT = new PhieuTra();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            formPT.MdiParent = this;
            formPT.Dock = DockStyle.Fill;
            formPT.Show();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiHang formLH = new LoaiHang();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            formLH.MdiParent = this;
            formLH.Dock = DockStyle.Fill;
            formLH.Show();
        }

        private void mặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MatHang formMH = new MatHang();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            formMH.MdiParent = this;
            formMH.Dock = DockStyle.Fill;
            formMH.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien formNV = new NhanVien();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            formNV.MdiParent = this;
            formNV.Dock = DockStyle.Fill;
            formNV.Show();
        }
    }
}
