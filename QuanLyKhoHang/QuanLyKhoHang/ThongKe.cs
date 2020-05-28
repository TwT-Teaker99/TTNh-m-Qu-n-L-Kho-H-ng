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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            demoChartSpline();
            demoChartDoughnut();
            demoChartPie();
            demoChartColumn();



        }
        private void demoChartSpline()
        {
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("1", "58");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("2", "90");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("3", "30");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("4", "50");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("5", "58");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("6", "78");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("7", "58");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("8", "96");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("9", "82");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("10", "92");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("11", "129");
            chart_spline.Series["Chi phí nhập kho"].Points.AddXY("12", "63");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("1", "41");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("2", "82");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("3", "63");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("4", "78");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("5", "21");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("6", "36");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("7", "54");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("8", "58");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("9", "63");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("10", "19");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("11", "72");
            chart_spline.Series["Chi phí xuất kho"].Points.AddXY("12", "45");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("1", "58");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("2", "72");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("3", "86");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("4", "22");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("5", "31");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("6", "51");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("7", "20");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("8", "58");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("9", "12");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("10", "64");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("11", "88");
            chart_spline.Series["Chi phí tồn kho"].Points.AddXY("12", "120");
        }
        private void demoChartDoughnut()
        {
           
            chart_doughnut.Series["s1"].IsValueShownAsLabel = true;
            chart_doughnut.Series["s1"].Points.AddXY("2014", "64588");
            chart_doughnut.Series["s1"].Points.AddXY("2015", "87236");
            chart_doughnut.Series["s1"].Points.AddXY("2016", "54300");
            chart_doughnut.Series["s1"].Points.AddXY("2017", "123403");
            chart_doughnut.Series["s1"].Points.AddXY("2018", "134003");
            chart_doughnut.Series["s1"].Points.AddXY("2019", "167240");

        }
        private void demoChartPie()
        {
            chart_pie.Series["s1"].IsValueShownAsLabel = true;
            chart_pie.Series["s1"].Points.AddXY("2014", "124");
            chart_pie.Series["s1"].Points.AddXY("2015", "158");
            chart_pie.Series["s1"].Points.AddXY("2016", "237");
            chart_pie.Series["s1"].Points.AddXY("2017", "56");
            chart_pie.Series["s1"].Points.AddXY("2018", "78");
            chart_pie.Series["s1"].Points.AddXY("2019", "64");
        }
        private void demoChartColumn()
            {
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("1", "36");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("2", "45");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("3", "27");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("4", "15");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("5", "52");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("6", "28");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("7", "36");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("8", "45");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("9", "42");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("10", "25");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("11", "44");
            chart_column.Series["Số lượng phiếu nhập"].Points.AddXY("12", "12");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("1", "32");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("2", "12");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("3", "65");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("4", "76");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("5", "89");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("6", "40");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("7", "36");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("8", "22");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("9", "37");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("10", "44");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("11", "58");
            chart_column.Series["Số lượng phiếu xuất"].Points.AddXY("12", "29");
            
        }
            private void chart4_Click(object sender, EventArgs e)
        {

        }
    }
}
