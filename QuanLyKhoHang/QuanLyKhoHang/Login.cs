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
    public partial class Login : Form
    {
        dbAccess db = new dbAccess();
        DataTable table = new DataTable();
        private int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxUName.Text = "";
            textBoxPass.Clear();
            textBoxUName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check username + password
            //db.readDataToAdapter("SELECT [MaNhanVien],[TaiKhoan],[MatKhau] FROM[dbo].[NhanVien] WHERE TaiKhoan = '" + textBoxUName.Text + "' and MatKhau = '" + textBoxPass.Text + "'", table);
            if(textBoxUName.Text=="" && textBoxPass.Text=="")
            {
               
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên đăng nhập và mật khẩu..!", "Sai Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       
        private void Login_Activated(object sender, EventArgs e)
        {
        
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
