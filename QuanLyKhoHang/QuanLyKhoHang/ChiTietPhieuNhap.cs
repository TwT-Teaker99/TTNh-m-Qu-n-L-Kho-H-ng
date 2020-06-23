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
    public partial class ChiTietPhieuNhap : Form
    {
        public string phieu_nhap_id,item_id,so_luong, don_gia,don_vi;
        SqlCommand cmd;
        functionShare funcShare = new functionShare();
        dbAccess database = new dbAccess();
        public ChiTietPhieuNhap(string phieu_nhap_id,string item_id,string so_luong,string don_gia,string don_vi)
        {
            InitializeComponent();
            this.Location = new Point(870, 350);
            this.so_luong = so_luong;
            this.don_gia = don_gia;
            this.don_vi = don_vi;
            this.phieu_nhap_id = phieu_nhap_id;
            this.item_id = item_id;
            textbox_soluong.Text = so_luong;
            textbox_donvi.Text = don_vi;
            textbox_cost.Text = don_gia;
          // funcShare = new functionShare();
           // database.pickSever();
            string query = "SELECT ten FROM mat_hang WHERE id=" + item_id;
            cmd = new SqlCommand(query);
           DataTable dataTable = new DataTable();
            database.pushDataTable(cmd, dataTable);

            label_ten.Text = dataTable.Rows[0]["ten"].ToString();
        }
        private bool checkInput()
        {
                e_cost.Visible = false;
            label_cost.Visible = false;
                  e_sl.Visible = false;
              label_sl.Visible = false;
                 e_dvi.Visible = false;
             label_dvi.Visible = false;
            bool check = true;
            if (!funcShare.isNumber(textbox_cost.Text))
            {
                e_cost.Visible = true;
                label_cost.Visible = true;
                check = false;
            }
            if (!funcShare.isNumber(textbox_soluong.Text))
            {
                e_sl.Visible = true;
                label_sl.Visible = true;
                check = false;
            }
            if (textbox_donvi.Text=="")
            {
                e_dvi.Visible = true;
                label_dvi.Visible = true;
                check = false;
            }
            return true;
        }
        private void but_xoa_Click(object sender, EventArgs e)
        {
            string xoa = "DELETE FROM chi_tiet_phieu_nhap WHERE phieu_nhap_id=" + phieu_nhap_id +" AND mat_hang_id="+item_id;
            cmd = new SqlCommand(xoa);
            database.editDB(cmd);
            //MessageBox.Show(xoa);
            this.Close();
        }

        private void but_fix_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                funcShare.update("chi_tiet_phieu_nhap", "so_luong,don_gia,don_vi",
     textbox_soluong.Text, textbox_cost.Text, funcShare.Nvarchar(textbox_donvi.Text),
     funcShare.where("phieu_nhap_id", phieu_nhap_id, "mat_hang_id", item_id));
            
                 this.Close();
            }
       
        }
      
        
    }
}
