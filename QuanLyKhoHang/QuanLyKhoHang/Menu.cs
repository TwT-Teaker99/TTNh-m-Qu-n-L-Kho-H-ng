using QuanLyKhoHang.Properties;
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
    public partial class Menu : Form
    {
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
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private bool isExpand1 = true;
        private bool isExpand2 = true;
        private bool isExpand3 = true;
        private int indexBut = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (indexBut)
            {
                case 1:
                    if (isExpand1)
                    {
                        but_nguon_nhap.Image = Resources.up_arrow;
                        p1.Height += 10;
                        if (p1.Size == p1.MaximumSize)
                        {
                            timer1.Stop();
                            isExpand1 = false;
                        }
                    }
                    else
                    {
                        but_nguon_nhap.Image = Resources.down_arrow;
                        p1.Height -= 10;
                        if (p1.Size == p1.MinimumSize)
                        {
                            timer1.Stop();
                            isExpand1 = true;
                        }

                    }
                    break;
                case 2:
                    if (isExpand2)
                    {
                        but_hang_hoa.Image = Resources.up_arrow;
                        p2.Height += 10;
                        if (p2.Size == p2.MaximumSize)
                        {
                            timer1.Stop();
                            isExpand2 = false;
                        }
                    }
                    else
                    {
                        but_hang_hoa.Image = Resources.down_arrow;
                        p2.Height -= 10;
                        if (p2.Size == p2.MinimumSize)
                        {
                            timer1.Stop();
                            isExpand2 = true;
                        }

                    }
                    break;
                case 3:
                    if (isExpand3)
                    {
                        but_nguon_xuat.Image = Resources.up_arrow;
                        p3.Height += 10;
                        if (p3.Size == p3.MaximumSize)
                        {
                            timer1.Stop();
                            isExpand3 = false;
                        }
                    }
                    else
                    {
                        but_nguon_xuat.Image = Resources.down_arrow;
                        p3.Height -= 10;
                        if (p3.Size == p3.MinimumSize)
                        {
                            timer1.Stop();
                            isExpand3 = true;
                        }

                    }
                    break;

            }

        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void but_expand(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_nguon_nhap":
                    indexBut = 1;
                    timer1.Start();
                    break;
                case "but_hang_hoa":
                    indexBut = 2;
                    timer1.Start();
                    break;
                case "but_nguon_xuat":
                    indexBut = 3;
                    timer1.Start();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pAdmin.Visible)
            {

                butAdmin.BackgroundImage = Resources.down_press;
                pAdmin.Visible = true;
                pAdmin.BringToFront();
            }
            else
            {
                butAdmin.BackgroundImage = Resources.down;
                pAdmin.Visible = false;
            }


        }

        public void call_form(Form child_form)
        {
            child_form.TopLevel = false;
            this.screen.Controls.Add(child_form);
              child_form.Dock = DockStyle.Fill;
            child_form.Show();
        }
        private void but_child_form(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_ncc":
                    this.screen.Controls.Clear();
                    NhaCungCap formNCC = new NhaCungCap();
                    call_form(formNCC);
                    break;
                case "but_phieu_nhap":
                    break;
                case "but_mat_hang":
                    break;
                case "but_loai_hang":
                    break;
                case "but_quay":
                    break;
                case "but_phieu_xuat":
                    this.screen.Controls.Clear();
                       QLXuat form_phieu_xuat = new QLXuat();
                       call_form(form_phieu_xuat);
                    break;
                case "but_nhan_vien":
                    this.screen.Controls.Clear();
                    NhanVien form_nv = new NhanVien();
                    call_form(form_nv);
                    break;

            }

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

        private void but_border(object sender, EventArgs e)
        {
           
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_resize":
                    this.WindowState = FormWindowState.Minimized;
                    break;          
                 
                case "but_exit":
                    this.Close();
                    break;
            }
           }
    }
}
