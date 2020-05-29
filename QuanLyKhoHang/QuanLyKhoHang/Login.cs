using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,     // x-coordinate of upper-left corner
       int nTopRect,      // y-coordinate of upper-left corner
       int nRightRect,    // x-coordinate of lower-right corner
       int nBottomRect,   // y-coordinate of lower-right corner
       int nWidthEllipse, // width of ellipse
       int nHeightEllipse // height of ellipse
   );
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
        private void but_border(object sender, EventArgs e)
        {

            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_resize":
                    this.WindowState = FormWindowState.Minimized;
                    break;

                case "but_exit":
                    Application.Exit();
                    break;
            }
        }
        private void Login_Activated(object sender, EventArgs e)
        {
        
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);


            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
