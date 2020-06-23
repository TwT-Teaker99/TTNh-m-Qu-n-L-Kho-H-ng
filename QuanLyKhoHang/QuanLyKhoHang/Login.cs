using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public static string user;

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTDN_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbTDN.Text == "Tên đăng nhập")
            {
                tbTDN.Text = "";
            }

            pnTDN.BackColor = Color.FromArgb(0, 168, 243);
            picTDN.BackgroundImage = Properties.Resources.tdn___2;

            if (tbMK.Text == "")
            {
                tbMK.PasswordChar = (char)0;
                tbMK.Text = "Mật khẩu";
                //tbMK.UseSystemPasswordChar = true;
            }

            pnMK.BackColor = Color.White;
            picMK.BackgroundImage = Properties.Resources.password;
        }

        private void tbMK_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbMK.Text == "Mật khẩu")
            {
                tbMK.Text = "";
            }
            tbMK.PasswordChar = '*';
            pnMK.BackColor = Color.FromArgb(0, 168, 243);
            picMK.BackgroundImage = Properties.Resources.password___2;

            if (tbTDN.Text == "")
            {
                tbTDN.Text = "Tên đăng nhập";
            }

            pnTDN.BackColor = Color.White;
            picTDN.BackgroundImage = Properties.Resources.tdn;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("TDN: " + tbTDN.Text + " and MK: " + tbMK.Text, "Thông báo");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select * from dbo.account where username = @user and password = @pw";
            sqlCommand.Parameters.AddWithValue("@user", tbTDN.Text);
            sqlCommand.Parameters.AddWithValue("@pw", tbMK.Text);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = dbAccess.connection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                user = tbTDN.Text;
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();


            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo");
            }
            //this.Show();
            //this.Hide();
            //Menu menu = new Menu();
            //menu.ShowDialog();
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
