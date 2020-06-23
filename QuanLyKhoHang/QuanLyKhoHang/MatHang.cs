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
    public partial class MatHang : Form
    {
        DataTable dt;
        string query = "SELECT  mat_hang.id , mat_hang.ten as ten ,loai_hang.ten as ten1, dbo.mat_hang.remain" +
            " FROM loai_hang INNER JOIN mat_hang ON loai_hang.id = mat_hang.loai_hang_id";
        functionShare funcShare;
        dbAccess db = new dbAccess();
        SqlCommand cmd;
        private string c1;
        private string c2;
        private string c3;
        private string c4;
        private string c5;
        private string c6;
        private bool isFormRegister = true;
        public MatHang()
        {
            InitializeComponent();
            db.pickSever(3);
            funcShare = new functionShare(3);
        }
        private void clear()
        {
            textbox_ten.Clear();
            textbox_loai.Clear();
            textbox_remain.Clear();
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
                funcShare.autoID(label_id, "mat_hang");
                label_sua.Visible = false;
                label_dk.Visible = true;
                but_register.Visible = true;
                but_sua.Visible = false;
                but_xoa.Visible = false;
                but_changeToRegis.Visible = false;
                isFormRegister = true;
            clear();
            }
        }
        private void LoadMatHang()
        {
            db.pushGridview(query, gridView);
        }
        private void MatHang_Load(object sender, EventArgs e)
        {
            LoadMatHang();
        }
        private void resetError()
        {
            label_error_ten.Visible = false;
            label_error_loai.Visible = false;
            label_error_remain.Visible = false;                   
            e_ten.Visible = false;
            e_loai.Visible = false;
            e_remain.Visible = false;
           
        }
        private bool checkInput()
        {
            resetError();
            bool check = true;
            if (textbox_ten.Text == "")
            {
                e_ten.Visible = true; check = false;

            }
            if (!funcShare.checkPK(textbox_loai.Text, "loai_hang"))
            {
                label_error_loai.Visible = true;
                e_loai.Visible = true;
                check = false;
            }
            if (!funcShare.isNumber(textbox_remain.Text))
            {
                label_error_remain.Visible = true;
                e_remain.Visible = true;
                check = false;
            }
            return true;
        }
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)//not header           
            {
                if (isFormRegister)
                {
                    changeToFormAlter();
                }
                label_id.Text = this.gridView.CurrentRow.Cells[0].Value.ToString();
                textbox_ten.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();               
                textbox_remain.Text = this.gridView.CurrentRow.Cells[3].Value.ToString();
                string temp_query = "SELECT * FROM mat_hang WHERE id=" + label_id.Text;
                cmd = new SqlCommand(temp_query);
                DataTable temp_dt = new DataTable();
                db.pushDataTable(cmd, temp_dt);

                textbox_loai.Text = temp_dt.Rows[0]["loai_hang_id"].ToString();
                

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
                        c2 = funcShare.Nvarchar(textbox_ten.Text);
                        c3 = textbox_remain.Text;
                        c4 = textbox_loai.Text;
                        funcShare.update("mat_hang", "ten,remain,loai_hang_id", c2, c3, c4, funcShare.where("id", c1));
                        changeToFormRegister();
                        LoadMatHang();                        
                    }
                    break;
                case "but_xoa":
                    string xoa = "DELETE FROM mat_hang WHERE id=" + label_id.Text;
                    cmd = new SqlCommand(xoa);
                    db.editDB(cmd);
                    changeToFormRegister();
                    LoadMatHang();

                    break;
            }
        }

        private void but_register_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                c1 = label_id.Text;
                c2 = funcShare.Nvarchar(textbox_ten.Text);
                c3 = textbox_loai.Text;
                c4 = textbox_remain.Text;
              
                funcShare.insert("mat_hang", "id, ten,loai_hang_id, remain", c1, c2, c3, c4);
                LoadMatHang();
                funcShare.autoID(label_id, "mat_hang");
                clear();
            }
            }

    private bool IsNullsearch()
        {
            if (textbox_search.Text == "")
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
                LoadMatHang();
            }
            else
            {
                while (true)
                {
                    if (comboBox_loc.Text == "")
                    {
                        string or = " OR ";
                        if (funcShare.isNumber(textbox_search.Text))
                        {
                            
                            string id = "mat_hang.id= " + textbox_search.Text;
                            string loai_hang_id = "loai_hang.id= " + textbox_search.Text;
                            string remain = "remain= " + textbox_search.Text;
                            search = query + " where "+id +or+loai_hang_id+or+remain;

                        }
                        else
                        {
                            string mat_hang_ten="( mat_hang.ten LIKE N'%" + textbox_search.Text + "%') ";
                            string loai_hang_ten = "( loai_hang.ten LIKE N'%" + textbox_search.Text + "%') ";
                            search = query + " where " + mat_hang_ten + or + loai_hang_ten;

                        }
                        db.pushGridview(search, gridView);
                        break;
                    }             
                    if (comboBox_loc.Text == "Tồn kho" && funcShare.isNumber(textbox_search.Text))
                    {
                        search = query + " where remain=" + textbox_search.Text;

                        db.pushGridview(search, gridView);
                        
                      

                        break;
                    }    
                    if (comboBox_loc.Text == "Loại hàng")
                    {
                        if (funcShare.isNumber(textbox_search.Text))
                        {
                            search = query + " where loai_hang.id=" + textbox_search.Text;

                        }
                        else
                        {
                            search = query + " where loai_hang.ten LIKE N'%" + textbox_search.Text + "%';";

                        }
                        db.pushGridview(search, gridView);
                        break;
                    }  
                    if (comboBox_loc.Text == "Mặt hàng")
                    {
                        if (funcShare.isNumber(textbox_search.Text))
                        {
                            search = query +" where mat_hang.id="+ textbox_search.Text;

                        }
                        else
                        {
                            search = query+" where mat_hang.ten LIKE N'%" + textbox_search.Text + "%';";

                        }
                        db.pushGridview(search, gridView);
                        break;
                    }   //v
                    break;
                }
            }
        }
    }
}
