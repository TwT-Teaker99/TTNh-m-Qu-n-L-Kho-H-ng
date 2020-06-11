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
        DataTable dt;
           string query = "SELECT phieu_nhap.id,nha_cung_cap.ten,ngay_nhap,nhan_vien.ten FROM " +
           "phieu_nhap,nha_cung_cap,nhan_vien where ncc_id=nha_cung_cap.id and nhan_vien_id=nhan_vien.id";
      
        functionShare funcShare;
        dbAccess database = new dbAccess();
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
            goiY(textbox_nv, "select id from nhan_vien");
            goiY(textbox_ncc, "select id from nha_cung_cap");
            goiY(textbox_item, "select id from mat_hang");
            goiY(textbox_donvi, "select distinct don_vi from chi_tiet_phieu_nhap");
        }
        private void goiY(TextBox tb, string s)
        {
            AutoCompleteStringCollection cbData = new AutoCompleteStringCollection();
            dbAccess.FillColl(cbData, s);
            tb.AutoCompleteCustomSource = cbData;
        }
        private void createDataTable(out DataTable datatable)
        {
            datatable = new DataTable();
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
                    funcShare.textboxLeave(textbox_nv, "Here");
                    break;
                case "textbox_ncc":
                    funcShare.textboxLeave(textbox_ncc, "Here");
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
                    funcShare.textboxEnter(textbox_nv, "Here");
                    break;
                case "textbox_ncc":
                    funcShare.textboxEnter(textbox_ncc, "Here");
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
            LoadPhieuNhap();
            funcShare.autoID(label_id, "phieu_nhap");


        }

        private void LoadPhieuNhap()
        {
            //  funcShare.loadGridView("phieu_nhap,nha_cung_cap,nhan_vien where ncc_id=nha_cung_cap.id and nhan_vien_id=nhan_vien.id"
            //   , "phieu_nhap.id,nha_cung_cap.ten,ngay_nhap,nhan_vien.ten", gridView);
            funcShare.loadGridView("PHIEUNHAP", gridView);
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
            if (textbox_donvi.Text == "đơn vị")
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
            if (isFormRegister)
            {
                if (e.RowIndex != -1)//not header           
                {

                    gridView2.Rows.RemoveAt(gridView2.CurrentCell.RowIndex);

                }
            }
            if (!isFormRegister)
            {
                c4 = gridView2.CurrentRow.Cells[0].Value.ToString();
                c1 = gridView2.CurrentRow.Cells[1].Value.ToString();
                c2 = gridView2.CurrentRow.Cells[2].Value.ToString();
                c3 = gridView2.CurrentRow.Cells[3].Value.ToString();

                ChiTietPhieuNhap sua_item = new ChiTietPhieuNhap(label_id.Text, c4, c1, c2, c3);
                sua_item.ShowDialog();
                funcShare.loadGridView("chi_tiet_phieu_nhap", "mat_hang_id,so_luong,don_gia,don_vi",
                  gridView2, funcShare.where("phieu_nhap_id", label_id.Text));
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
                string temp_query = "SELECT * FROM phieu_nhap WHERE id=" + this.gridView.CurrentRow.Cells[0].Value.ToString();
                cmd = new SqlCommand(temp_query);
                 DataTable temp_dt = new DataTable();
                database.pushDataTable(cmd, temp_dt);

                textbox_nv.Text = temp_dt.Rows[0]["nhan_vien_id"].ToString();
                textbox_ncc.Text = temp_dt.Rows[0]["ncc_id"].ToString();
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
                LoadPhieuNhap();
                clear();
                funcShare.autoID(label_id, "phieu_nhap");

            }
        }
        private void clear()
        {
            textbox_nv.Clear(); funcShare.textboxLeave(textbox_nv, "Here");
            textbox_ncc.Clear(); funcShare.textboxLeave(textbox_ncc, "Here");
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
                    if (!isFormRegister)
                    {
                        c1 = textbox_item.Text;
                        c2 = textbox_soluong.Text;
                        c3 = textbox_cost.Text;
                        c4 = textbox_donvi.Text;
                        dt = new DataTable();
                        dt = (DataTable)gridView2.DataSource;
                        dt.Rows.Add(c1, c2, c3, c4);
                        gridView2.DataSource = dt;
                        c4 = funcShare.Nvarchar(textbox_donvi.Text);
                        funcShare.insertNoIdentity("chi_tiet_phieu_nhap", "phieu_nhap_id,mat_hang_id,so_luong,don_gia,don_vi", label_id.Text, c1, c2, c3, c4);
                    }

                }

            }
        }
        private void changeToFormAlter()
        {
            if (isFormRegister)
            {
                label_dk.Location = new System.Drawing.Point(3, 9);
                label_dk.Text = "Chi tiết phiếu nhập";
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
                label_dk.Location = new System.Drawing.Point(52, 7);
                label_dk.Text = "Tạo phiếu nhập";
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


        private void but_form_alter(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_changeToRegis":
                    changeToFormRegister();
                    break;
                case "but_sua":
                    if (checkInput())
                    {
                        c1 = label_id.Text;
                        c2 = textbox_ncc.Text;
                        c3 = funcShare.date(textbox_ngay.Text, textbox_thang.Text, textbox_nam.Text);
                        c4 = textbox_nv.Text;
                        funcShare.update("phieu_nhap", "ncc_id,ngay_nhap,nhan_vien_id", c2, c3, c4, funcShare.where("id", c1));
                        changeToFormRegister();
                        LoadPhieuNhap();
                    }
                    break;
                case "but_xoa":
                    string xoa = "DELETE FROM phieu_nhap WHERE id=" + label_id.Text;
                    cmd = new SqlCommand(xoa);
                    database.editDB(cmd);
                    changeToFormRegister();
                    LoadPhieuNhap();

                    break;
            }
        }
        private bool IsNullsearch()
        {
            if (textbox_search.Text == "Tìm kiếm")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void but_search_Click(object sender, EventArgs e)
        {
                     
            string search;
            if (IsNullsearch())
            {
                LoadPhieuNhap();
            }
            else
            {
                while (true)
                {
                    if (comboBox_loc.Text == "")
                    {
                        if (funcShare.isNumber(textbox_search.Text))
                        {
                            string or = " OR ";
                            string searchID = "phieu_nhap.id= " + textbox_search.Text;                          
                            string ngay = "DAY(ngay_nhap) = " + textbox_search.Text;
                            string thang = "MONTH(ngay_nhap) = " + textbox_search.Text;
                            search = query + " and (" + searchID + or +ngay+or+thang+")";
                            
                        }
                        else 
                        {
                            if (funcShare.isDate(textbox_search.Text) == true)
                            {
                                string[] arr = textbox_search.Text.Split('/', '-');

                                search = query + " and ngay_nhap =" + funcShare.date(arr[0], arr[1], arr[2]);
                                

                            }
                            else
                            {
                                string tenNCC = "nha_cung_cap.ten LIKE N'%" + textbox_search.Text + "%'";
                                string tenNV = "nhan_vien.ten LIKE N'%" + textbox_search.Text + "%'";
                                search = query + " and (" + tenNCC + " or " + tenNV + ")";
                            }    

                        }
                        database.pushGridview(search, gridView);
                        break;
                    }
                    if (comboBox_loc.Text == "Mã phiếu nhập hàng" && funcShare.isNumber(textbox_search.Text))
                    {
                        search = query + " and phieu_nhap.id=" + textbox_search.Text;

                        database.pushGridview(search, gridView);
                        break;
                    }  //v
                    if (comboBox_loc.Text == "Nhà cung cấp")
                    {
                        if (funcShare.isNumber(textbox_search.Text))
                        {
                            search = query + " and ncc_id=" + textbox_search.Text;                          
                        }
                        else
                        {
                         string  like = "nha_cung_cap.ten LIKE N'%" + textbox_search.Text + "%'";
                            search = query + " and " +like ;
                                                    }
                        database.pushGridview(search, gridView);
                        break;
                    }  //v
                    if (comboBox_loc.Text == "Ngày nhập")
                    {
                        if (funcShare.isNumber(textbox_search.Text))
                        {
                            if (textbox_search.Text.Length<=2)
                            {
                                search = query + " and (DAY(ngay_nhap)=" + textbox_search.Text +" or MONTH(ngay_nhap)=" + textbox_search.Text+")";
                            }
                            else
                            {
                                search = query + " and YEAR(ngay_nhap)=" + textbox_search.Text;
                            }
                            database.pushGridview(search, gridView);
                        }
                        else
                        {
                            if (funcShare.isDate(textbox_search.Text) == true)
                            {
                                string[] arr = textbox_search.Text.Split('/','-');                               
                                search = query + " and ngay_nhap =" + funcShare.date(arr[0],arr[1],arr[2]) ;
                                database.pushGridview(search, gridView);
                            }

                        }
                        
                        break;
                    }    //v
                    if (comboBox_loc.Text == "Nhân viên")
                    {
                        if (funcShare.isNumber(textbox_search.Text))
                        {
                            search = query + " and nhan_vien_id=" + textbox_search.Text;
                           
                        }
                        else
                        {
                            string like = "nhan_vien.ten LIKE N'%" + textbox_search.Text + "%'";
                            search = query + " and " + like;
                        }
                        database.pushGridview(search, gridView);
                        break;
                    }  //v
                    if (comboBox_loc.Text == "Mặt hàng")
                    {
                        if (funcShare.isNumber(textbox_search.Text))
                        {              
            search = "SELECT distinct phieu_nhap.id,nha_cung_cap.ten,ngay_nhap,nhan_vien.ten FROM " +
            "phieu_nhap,nha_cung_cap,nhan_vien,chi_tiet_phieu_nhap " +
            "where ncc_id=nha_cung_cap.id and nhan_vien_id=nhan_vien.id " +
            "and phieu_nhap.id = phieu_nhap_id and mat_hang_id =" + textbox_search.Text;
                         
                        }
                        else
                        {
                            search = "SELECT distinct phieu_nhap.id,nha_cung_cap.ten,ngay_nhap,nhan_vien.ten FROM " +
         "phieu_nhap,nha_cung_cap,nhan_vien,chi_tiet_phieu_nhap,mat_hang " +
         "where ncc_id=nha_cung_cap.id and nhan_vien_id=nhan_vien.id " +
         "and phieu_nhap.id = phieu_nhap_id and mat_hang_id = mat_hang.id and mat_hang.ten LIKE N'%" + textbox_search.Text + "%';";

                        }
                        database.pushGridview(search, gridView);
                        break;
                    }   //v
                    break;
                }
            }
            
            




           
        }




    }












    
}
