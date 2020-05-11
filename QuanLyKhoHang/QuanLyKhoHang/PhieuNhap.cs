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
        functionShare funcShare;
        dbAccess database = new dbAccess();
        private string c1;
        private string c2;
        private string c3;
        private string c4;
        private string c5;
        private string c6;
        public PhieuNhap()
        {
            InitializeComponent();
            int sever = 1;
            database.pickSever(sever);           
            funcShare = new functionShare(sever);
        }

       
        private void textbox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            switch (textBox.Name)
            {
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
            funcShare.loadGridView("phieu_nhap", gridView);
            funcShare.autoID(label_id, "phieu_nhap");  
         
           


        }     
        private bool checkInput()
        { bool check = true;
            if (!funcShare.isNumber(textbox_soluong.Text)||database.SelectHasRow(query))
            {
                check = false;
            }
            if (!funcShare.isNumber(textbox_soluong.Text))
            {
                check = false;
            }
            if (!funcShare.isNumber(textbox_soluong.Text))
            {
                check = false;
            }
            return check;
        }
        private void but_register_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                c1 = label_id.Text;
                c2 = textbox_nv.Text;
                c3 = textbox_ncc.Text;
                c4 = textbox_ngay.Text+ textbox_thang.Text+ textbox_nam.Text;
               

                funcShare.insert("phieu_nhap", "id,ncc_id,ngay_nhap,nhan_vien_id", c1, c2, c3, c4);
            }
        }
        private bool checkInput2()
        {
            bool check = true;
            if (!funcShare.isNumber(textbox_soluong.Text))
            {
                check = false;
            }
            if (!funcShare.isNumber(textbox_cost.Text))
            {
                check = false;
            }
            return check; 
        }
        private void but_child_regis(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
               case "but_add":
                //    if (checkInput2())
                   // {
                        c1 = textbox_item.Text;
                        c2 = textbox_soluong.Text;
                        c3 = textbox_cost.Text;
                        c4 = textbox_donvi.Text;
                        gridView2.Rows.Add(c1, c2, c3, c4);
                   // }
                   
                    break;
                case "but_del":
                    if (gridView2.Rows.Count>1)
                    {
                         gridView2.Rows.RemoveAt(gridView2.CurrentCell.RowIndex);
                    }

                    



                    break;
            }
        }
        /*
         * MessageBox.Show(Convert.ToString(gridView2.Rows.Count));
         *  INSERT INTO phieu_nhap
(   ncc_id,   nhan_vien_id,   ngay_nhap)
VALUES 	( 1,1, '20190110')
         */










    }
}
