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
    public partial class PhieuNhap : Form
    {
        DataTable dt ;
        string query = "SELECT * FROM phieu_nhap";
        functionShare funcShare;
        dbAccess database= new dbAccess();
        SqlCommand cmd;
        private string c1;
        private string c2;
        private string c3;
        private string c4;
        private string c5;
        private string c6;
        private bool isFormRegister = true;
        public PhieuNhap()
        {
            InitializeComponent();
            int sever = 1;
            database.pickSever(sever);
            funcShare = new functionShare(sever);
            createDataTable(out dt);
          
        }

        public void createDataTable(out DataTable datatable)
        {
            datatable= new DataTable();
            datatable.Columns.Add(new DataColumn("mat_hang_id", typeof(string)));
            datatable.Columns.Add(new DataColumn("so_luong", typeof(string)));           
            datatable.Columns.Add(new DataColumn("don_gia", typeof(string)));
            datatable.Columns.Add(new DataColumn("don_vi", typeof(string)));
        }

        private void textbox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            switch (textBox.Name)
            {
                case "textbox_search":
                    funcShare.textboxLeave(textbox_search, "Tìm kiếm");
                    break;
                case "textbox_nv":
                    funcShare.textboxLeave(textbox_nv, "Nhập mã nhân viên");
                    break;
                case "textbox_ncc":
                    funcShare.textboxLeave(textbox_ncc, "Nhập mã nhà cung cấp");
                    break;
                case "textbox_ngay":
                    funcShare.textboxLeave(textbox_ngay, "Ngày");
                    break;
                case "textbox_thang":
                    funcShare.textboxLeave(textbox_thang, "Tháng");
                    break;
                case "textbox_nam":
                    funcShare.textboxLeave(textbox_nam, "Năm");
                    break;
                case "textbox_item":
                    funcShare.textboxLeave(textbox_item, "mã mặt hàng");
                    break;
                case "textbox_donvi":
                    funcShare.textboxLeave(textbox_donvi, "đơn vị");
                    break;
                case "textbox_cost":
                    funcShare.textboxLeave(textbox_cost, "đơn giá");
                    break;
                case "textbox_soluong":
                    funcShare.textboxLeave(textbox_soluong, "số lượng");
                    break;

            }
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            switch (textBox.Name)
            {
                case "textbox_search":
                    funcShare.textboxEnter(textbox_search, "Tìm kiếm");
                    break;
                case "textbox_nv":
                    funcShare.textboxEnter(textbox_nv, "Nhập mã nhân viên");
                    break;
                case "textbox_ncc":
                    funcShare.textboxEnter(textbox_ncc, "Nhập mã nhà cung cấp");
                    break;
                case "textbox_ngay":
                    funcShare.textboxEnter(textbox_ngay, "Ngày");
                    break;
                case "textbox_thang":
                    funcShare.textboxEnter(textbox_thang, "Tháng");
                    break;
                case "textbox_nam":
                    funcShare.textboxEnter(textbox_nam, "Năm");
                    break;
                case "textbox_item":
                    funcShare.textboxEnter(textbox_item, "mã mặt hàng");
                    break;
                case "textbox_donvi":
                    funcShare.textboxEnter(textbox_donvi, "đơn vị");
                    break;
                case "textbox_cost":
                    funcShare.textboxEnter(textbox_cost, "đơn giá");
                    break;
                case "textbox_soluong":
                    funcShare.textboxEnter(textbox_soluong, "số lượng");
                    break;

            }
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            this.gridView.Columns[2].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            funcShare.loadGridView("phieu_nhap", gridView);
            funcShare.autoID(label_id, "phieu_nhap");
         

        }


        private void resetError()
        {
            label_last.Visible = false;
            label_nv.Visible = false;
            label_ncc.Visible = false;
            label_date.Visible = false;
            label_cost.Visible = false;
            label_item.Visible = false;
            label_sl.Visible = false;
            e_nv.Visible = false;
            e_ncc.Visible = false;
            e_date.Visible = false;
            e_cost.Visible = false;
            e_item.Visible = false;
            e_sl.Visible = false;
            e_dvi.Visible = false;
        }
        private bool checkInput()
        {
            resetError();
            bool check = true;
            if (!funcShare.checkPK(textbox_nv.Text, "nhan_vien"))
            {
                label_nv.Visible = true;
                e_nv.Visible = true;
                check = false;
            }
            if (!funcShare.checkPK(textbox_ncc.Text, "nha_cung_cap"))
            {
                label_ncc.Visible = true;
                e_ncc.Visible = true;
                check = false;
            }
            if (!funcShare.checkDate(textbox_ngay.Text, textbox_thang.Text, textbox_nam.Text))
            {
                label_date.Visible = true;
                e_date.Visible = true;
                check = false;
            }
            if (gridView2.Rows.Count == 0)
            {
                label_last.Visible = true;
                check = false;
            }
            return check;
        }
        private bool checkInput2()
        {
            resetError();
            bool check = true;
            if (!funcShare.checkPK(textbox_item.Text, "mat_hang"))
            {
                label_item.Text = "Mã Mh không tồn tại";
                label_item.Visible = true;
                e_item.Visible = true;
                check = false;
            }
            if (!funcShare.isNumber(textbox_soluong.Text))
            {
                label_sl.Visible = true;
                e_sl.Visible = true;
                check = false;
            }
            if (!funcShare.isNumber(textbox_cost.Text))
            {
                label_cost.Visible = true;
                e_cost.Visible = true;
                check = false;
            }
            if (textbox_donvi.Text== "đơn vị")
            {
                e_dvi.Visible = true;
                check = false;
            }
            return check;
        }
        private bool checkInput2_1()
        {
            for (int i = 0; i < gridView2.Rows.Count; i++)
            {
                if (gridView2.Rows[i].Cells[0].Value.ToString() == textbox_item.Text)
                {
                    label_item.Text = "mã MH đã có";
                    label_item.Visible = true;
                    e_item.Visible = true;
                    return false;
                }
            }

            return true;
        }
        private void gridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)//not header           
            {

                gridView2.Rows.RemoveAt(gridView2.CurrentCell.RowIndex);

            }
        }
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)//not header           
            {
                if (isFormRegister)
                {
                    changeToFormAlter();
                }
                textbox_nv.ForeColor = Color.Black;
                textbox_ncc.ForeColor = Color.Black;
                textbox_ngay.ForeColor = Color.Black;
                textbox_thang.ForeColor = Color.Black;
                textbox_nam.ForeColor = Color.Black;
                label_id.Text = this.gridView.CurrentRow.Cells[0].Value.ToString();
                textbox_nv.Text = this.gridView.CurrentRow.Cells[3].Value.ToString();
                textbox_ncc.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
                funcShare.getDate(this.gridView.CurrentRow.Cells[2].Value.ToString(), textbox_ngay, textbox_thang, textbox_nam);
                funcShare.loadGridView("chi_tiet_phieu_nhap", "mat_hang_id,so_luong,don_gia,don_vi",
                    gridView2, funcShare.where("phieu_nhap_id", label_id.Text));


            }
        }
        private void but_register_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                c1 = label_id.Text;
                c2 = textbox_ncc.Text;
                c3 = funcShare.date(textbox_ngay.Text, textbox_thang.Text, textbox_nam.Text);
                c4 = textbox_nv.Text;
                funcShare.insert("phieu_nhap", "id,ncc_id,ngay_nhap,nhan_vien_id", c1, c2, c3, c4);
                for (int i = 0; i < gridView2.Rows.Count; i++)
                {
                    c2 = gridView2.Rows[i].Cells[0].Value.ToString();
                    c3 = gridView2.Rows[i].Cells[1].Value.ToString();
                    c4 = gridView2.Rows[i].Cells[2].Value.ToString();
                    c5 = funcShare.Nvarchar(gridView2.Rows[i].Cells[3].Value.ToString());
            funcShare.insertNoIdentity("chi_tiet_phieu_nhap", "phieu_nhap_id,mat_hang_id,so_luong,don_gia,don_vi", c1, c2, c3, c4, c5);
                }
                funcShare.loadGridView("phieu_nhap", gridView);
                clear();
                funcShare.autoID(label_id, "phieu_nhap");

            }
        }
        private void clear()
        {
            textbox_nv.Clear(); funcShare.textboxLeave(textbox_nv, "Nhập mã nhân viên");
            textbox_ncc.Clear(); funcShare.textboxLeave(textbox_ncc, "Nhập mã nhà cung cấp");
            textbox_ngay.Clear(); funcShare.textboxLeave(textbox_ngay, "Ngày");
            textbox_thang.Clear(); funcShare.textboxLeave(textbox_thang, "Tháng");
            textbox_nam.Clear(); funcShare.textboxLeave(textbox_nam, "Năm");
            textbox_item.Clear(); funcShare.textboxLeave(textbox_item, "mã mặt hàng");
            textbox_donvi.Clear(); funcShare.textboxLeave(textbox_donvi, "đơn vị");
            textbox_cost.Clear(); funcShare.textboxLeave(textbox_cost, "đơn giá");
            textbox_soluong.Clear(); funcShare.textboxLeave(textbox_soluong, "số lượng");
            while (gridView2.Rows.Count > 0)
            {
                gridView2.Rows.RemoveAt(0);
            }
        }
        private void but_add_Click(object sender, EventArgs e)
        {
            if (checkInput2())
            {
                if (checkInput2_1())
                {
                    if (isFormRegister)
                    {
                        c1 = textbox_item.Text;
                        c2 = textbox_soluong.Text;
                        c3 = textbox_cost.Text;
                        c4 = textbox_donvi.Text;

                        dt.Rows.Add(c1, c2, c3, c4);
                       
                        gridView2.DataSource = dt;
                    }
                    else
                    {
                        c1 = textbox_item.Text;
                        c2 = textbox_soluong.Text;
                        c3 = textbox_cost.Text;
                        c4 = textbox_donvi.Text;
                        dt = new DataTable();
                        dt = (DataTable)gridView2.DataSource;
                        dt.Rows.Add(c1, c2, c3, c4);                     
                        gridView2.DataSource = dt;
                    }    
                 
                }

            }
        }
        private void changeToFormAlter()
        {
            if (isFormRegister)
            {
                label_dk.Location = new System.Drawing.Point(34, 9);
                label_dk.Text = "Chi tiết đơn hàng";
                but_register.Visible = false;
                but_sua.Visible = true;
                but_xoa.Visible = true;
                isFormRegister = false;
                but_changeToRegis.Visible = true;
                resetError();
                textbox_item.Clear(); funcShare.textboxLeave(textbox_item, "mã mặt hàng");
                textbox_donvi.Clear(); funcShare.textboxLeave(textbox_donvi, "đơn vị");
                textbox_cost.Clear(); funcShare.textboxLeave(textbox_cost, "đơn giá");
                textbox_soluong.Clear(); funcShare.textboxLeave(textbox_soluong, "số lượng");

            }

        }
        private void changeToFormRegister()
        {
            if (!isFormRegister)
            {
                createDataTable(out dt);
                label_dk.Location = new System.Drawing.Point(91, 9);
                label_dk.Text = "Lập đơn hàng";
                funcShare.autoID(label_id, "phieu_nhap");
                but_register.Visible = true;
                but_sua.Visible = false;
                but_xoa.Visible = false;
                but_changeToRegis.Visible = false;
                isFormRegister = true;
                resetError();
                clear();
                
              
            
            }

        }
     

        private void but_form_alter(object sender, EventArgs e)//but sua chua lam
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_changeToRegis":
                    changeToFormRegister();
                    break;
                case "but_sua":
                    break;
                case "but_xoa":
                    string xoa = "DELETE FROM phieu_nhap WHERE id=" + label_id.Text;
                     cmd = new SqlCommand(xoa);                
                    database.editDB(cmd);
                    changeToFormRegister();
                    funcShare.loadGridView("phieu_nhap", gridView);
                    funcShare.autoID(label_id, "phieu_nhap");
                    break;
            }
        }

        
        /*
      nút thêm item  trong trường hợp alter
      nút sửa
      sự kiện click đúp vào gridview2 trong trường hợp alter

         */









    }
}
