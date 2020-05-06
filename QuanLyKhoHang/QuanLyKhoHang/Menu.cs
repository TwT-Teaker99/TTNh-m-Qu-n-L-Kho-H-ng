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
                pAdmin.Visible = true;
            }
            else
            pAdmin.Visible = false;

        }
    }
}
