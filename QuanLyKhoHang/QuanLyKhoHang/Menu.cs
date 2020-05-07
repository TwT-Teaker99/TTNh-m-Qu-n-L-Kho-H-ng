using QuanLyKhoHang.Properties;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void but_child_form(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "but_ncc":
                    this.screen.Controls.Clear();
                    NhaCungCap formNCC = new NhaCungCap();
                    formNCC.TopLevel = false;
                     this.screen.Controls.Add(formNCC);
                    formNCC.Dock = DockStyle.Fill;
                    formNCC.Show();
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
                    break;
                case "but_nhan_vien":
                    break;

            }

        }
    }
}
