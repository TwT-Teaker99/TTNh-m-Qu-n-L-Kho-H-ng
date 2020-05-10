using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class NhaCungCap : Form
    {
        dbAccess database = new dbAccess();
        SqlCommand comman;     
        string query = "SELECT * FROM nha_cung_cap";
        functionShare funcShare;
        private bool sort_id;
        private bool sort_ten;
        private bool sort_sdt;
        private bool sort_quan;
        private bool sort_phuong;
        private bool sort_city;
        private bool isFormRegister=true;


        public NhaCungCap()
        {
            InitializeComponent();
          int sever = 1;
            database.pickSever(sever);
            funcShare = new functionShare(sever);
        }
      
    
        private void NhaCungCap_Load(object sender, EventArgs e)
        {

            funcShare.loadGridView("nha_cung_cap", gridView);
            funcShare.autoID(label_id,"nha_cung_cap");
        }

        private void but_sort_click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            string root = query + " ORDER BY ";
            switch (but.Name)
            {
                case "but_sort_id":
                    if (sort_id)
                    {
                        root += " 1 ASC;";
                        sort_id = false;
                    }
                    else
                    {
                        root += " 1 DESC;";
                        sort_id = true;
                    }
                    break;

                case "but_sort_ten":
                    if (sort_ten)
                    {
                        root += " 2 ASC;";
                        sort_ten = false;
                    }
                    else
                    {
                        root += " 2 DESC;";
                        sort_ten = true;
                    }


                    break;
                case "but_sort_sdt":
                    if (sort_sdt)
                    {
                        root += " 3 ASC;";
                        sort_sdt = false;
                    }
                    else
                    {
                        root += " 3 DESC;";
                        sort_sdt = true;
                    }
                    break;
                case "but_sort_quan":
                    if (sort_quan)
                    {
                        root += " 4 ASC;";
                        sort_quan = false;
                    }
                    else
                    {
                        root += " 4 DESC;";
                        sort_quan = true;
                    }

                    break;
                case "but_sort_phuong":
                    if (sort_phuong)
                    {
                        root += " 5 ASC;";
                        sort_phuong = false;
                    }
                    else
                    {
                        root += " 5 DESC;";
                        sort_phuong = true;
                    }
                    break;
                case "but_sort_city":
                    if (sort_city)
                    {
                        root += " 6 ASC;";
                        sort_city = false;
                    }
                    else
                    {
                        root += " 6 DESC;";
                        sort_city = true;
                    }
                    break;

            }
            comman = new SqlCommand(root);
            database.pushGridview(comman, gridView);
        }


        private void but_search_Click(object sender, EventArgs e)
        {
            if (textbox_search.Text != "")
            {
                string inputSearch = textbox_search.Text;
                string root = query + " WHERE ";
                string or = " OR ";
                string searchTen;
                if (funcShare.isNumber(inputSearch))
                {

                    string searchID = "id= " + inputSearch;
                    searchTen = "ten LIKE N'%" + inputSearch + "%'";
                    string searchSdt = "sdt LIKE N'%" + inputSearch + "%'";

                    root = root + searchID + or + searchTen + or + searchSdt;


                }
                else
                {
                    searchTen = "ten LIKE N'%" + inputSearch + "%'";
                    string searchPhuong = "phuong LIKE N'%" + inputSearch + "%'";
                    string searchQuan = "quan LIKE N'%" + inputSearch + "%'";
                    string searchCity = "city LIKE N'%" + inputSearch + "%'";
                    root = root + searchTen + or + searchPhuong + or + searchQuan + or + searchCity;
                }
                //  MessageBox.Show(root);
                comman = new SqlCommand(root);
                database.pushGridview(comman, gridView);
            }
        }        
        private void resetRegister()
        {
            textbox_ten.Clear();
            textbox_sdt.Clear();
            textbox_quan.Clear();
            textbox_phuong.Clear();
            textbox_city.Clear();
        }
        private void resetError()
        {
            but_error_ten.Visible = false;
            but_error_sdt.Visible = false;
            but_error_phuong.Visible = false;
            but_error_quan.Visible = false;
            but_error_city.Visible = false;
        }
        private bool kiemTraInput()
        {
            bool check = true;
            resetError();
            if (textbox_ten.Text == "")
            {
                but_error_ten.Visible = true; check = false;

            }
            if (!funcShare.isNumber(textbox_sdt.Text) || textbox_sdt.Text.Length > 11 || textbox_sdt.Text.Length < 6)
            {
                but_error_sdt.Visible = true; check = false;

            }
            if (textbox_phuong.Text == "" || funcShare.isNumber(textbox_phuong.Text))
            {
                but_error_phuong.Visible = true; check = false;

            }
            if (textbox_quan.Text == "" || funcShare.isNumber(textbox_quan.Text))
            {
                but_error_quan.Visible = true; check = false;

            }
            if (textbox_city.Text == "" || funcShare.isNumber(textbox_city.Text))
            {
                but_error_city.Visible = true; check = false;

            }
            return check;

        }
        private void but_register_Click(object sender, EventArgs e)
        {
            if (kiemTraInput())
            {
                string query = "SET IDENTITY_INSERT nha_cung_cap ON;" +
                 "INSERT INTO nha_cung_cap ( id,ten,sdt, quan, phuong, city) " +
          "VALUES (" + label_id.Text + ",N'" + textbox_ten.Text + "',N'" + textbox_sdt.Text + "', N'" +
          textbox_quan.Text + "', N'" + textbox_phuong.Text + "', N'" + textbox_city.Text + "')  "
                   + "SET IDENTITY_INSERT nha_cung_cap OFF;";
                comman = new SqlCommand(query);
                database.editDB(comman);
                funcShare.loadGridView("nha_cung_cap", gridView);
                resetRegister();
                funcShare.autoID(label_id, "nha_cung_cap");
            }

        }

        private void but_error(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_error_ten":
                    if (label_error_ten.Visible)
                    {
                        label_error_ten.Visible = false;
                    }
                    else
                    {
                        label_error_ten.Visible = true;
                    }
                    break;
                case "but_error_sdt":
                    if (label_error_sdt.Visible)
                    {
                        label_error_sdt.Visible = false;
                    }
                    else
                    {
                        label_error_sdt.Visible = true;
                    }
                    break;
                case "but_error_quan":
                    if (label_error_quan.Visible)
                    {
                        label_error_quan.Visible = false;
                    }
                    else
                    {
                        label_error_quan.Visible = true;
                    }
                    break;
                case "but_error_phuong":
                    if (label_error_phuong.Visible)
                    {
                        label_error_phuong.Visible = false;
                    }
                    else
                    {
                        label_error_phuong.Visible = true;
                    }
                    break;
                case "but_error_city":
                    if (label_error_city.Visible)
                    {
                        label_error_city.Visible = false;
                    }
                    else
                    {
                        label_error_city.Visible = true;
                    }
                    break;
            }
        }
        private void changeToFormAlter()
        {
            if (isFormRegister)
            {
                label_sua.Visible = true;
                label_dk.Visible = false;
                but_register.Visible = false;
                but_sua.Visible = true;
                but_xoa.Visible = true;
                isFormRegister = false;
                but_changeToRegis.Visible = true;
            }

        }
        private void changeToFormRegister()
        {
            if (!isFormRegister)
            {
                funcShare.autoID(label_id, "nha_cung_cap");
                label_sua.Visible = false;
                label_dk.Visible = true;
                but_register.Visible = true;
                but_sua.Visible = false;
                but_xoa.Visible = false;
                but_changeToRegis.Visible = false;
                isFormRegister = true;
                textbox_ten.Clear();
                textbox_sdt.Clear();
                textbox_quan.Clear();
                textbox_phuong.Clear();
                textbox_city.Clear();
            }

        }
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // NhaCungCap_Alter sua_xoa = new NhaCungCap_Alter();
            // sua_xoa.ShowDialog(this);          
            if (isFormRegister)
            {
                changeToFormAlter();
            }
            label_id.Text = this.gridView.CurrentRow.Cells[0].Value.ToString();
            textbox_ten.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
            textbox_sdt.Text = this.gridView.CurrentRow.Cells[2].Value.ToString();
            textbox_quan.Text = this.gridView.CurrentRow.Cells[3].Value.ToString();
            textbox_phuong.Text = this.gridView.CurrentRow.Cells[4].Value.ToString();
            textbox_city.Text = this.gridView.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void but_sua_xoa_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_sua":
                    if (kiemTraInput())
                    {
                        string update = "UPDATE nha_cung_cap SET ten=N'" + textbox_ten.Text +
                   "' ,sdt= '" + textbox_sdt.Text + "' ,quan= N'" + textbox_quan.Text + 
                    "' ,phuong= N'" + 
                   textbox_phuong.Text + "' ,city= N'" + textbox_city.Text + "' WHERE id=" + label_id.Text;                     
                        comman = new SqlCommand(update);
                        database.editDB(comman);
                        funcShare.loadGridView("nha_cung_cap", gridView);
                        changeToFormRegister();
                    }
                    break;
                case "but_xoa":
                    string delete = "DELETE FROM nha_cung_cap WHERE id =" +label_id.Text;
                    comman = new SqlCommand(delete);
                    database.editDB(comman);
                    funcShare.loadGridView("nha_cung_cap", gridView);
                    changeToFormRegister();
                    break;

                case "but_changeToRegis":
                    changeToFormRegister();
                    break;

            }
            
           
          
            
        }
    }
}

