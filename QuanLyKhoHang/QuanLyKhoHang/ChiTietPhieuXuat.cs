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
    public partial class ChiTietPhieuXuat : Form
    {
        public ChiTietPhieuXuat()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private string id, date,quay,nv;
        public string Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string Quay { get => quay; set => quay = value; }
        public string NV { get => nv; set => nv = value; }
        private void ChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            tbMP.Text = Id;
            tbNL.Text = Date;
            tbMQ.Text = Quay;
            tbMNV.Text = NV;
            tbTQ.Text = dbAccess.GetFieldValues("select ten from quay where id=" + Quay);
            tbTNV.Text = dbAccess.GetFieldValues("select ten from nhan_vien where id = " + NV );
            string query = "select mat_hang_id,ten,so_luong from chi_tiet_phieu_xuat,mat_hang where mat_hang_id=id and phieu_xuat_id='"+id+"'";
            dbAccess.GetData(query, dataGridView1);
        }
    }
}
