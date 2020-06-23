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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();

            demoChartDoughnut();
            demoChartColumn();
            db.pickSever(3);
            functionShare share = new functionShare(3);


        }
        dbAccess db = new dbAccess();
        private void demoChartDoughnut()
        {

            chart_doughnut.Series["s1"].IsValueShownAsLabel = true;
            chart_doughnut.Series["s1"].Points.AddXY("2014", "64588");
            chart_doughnut.Series["s1"].Points.AddXY("2015", "87236");
            chart_doughnut.Series["s1"].Points.AddXY("2016", "54300");
            chart_doughnut.Series["s1"].Points.AddXY("2017", "123403");



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

        private void ThongKe_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select COUNT(id) from nhan_vien ";
            labelTongNV.Text = dbAccess.GetFieldValues("select COUNT(id) from nhan_vien");
            labelTongHang.Text = dbAccess.GetFieldValues("select COUNT(id) from mat_hang");
            labelTongNCC.Text = dbAccess.GetFieldValues("select COUNT(id) from nha_cung_cap");
            labelTongChiPhi.Text = dbAccess.GetFieldValues("select sum(so_luong*don_gia) from chi_tiet_phieu_nhap");
            dbAccess.FillCombo("select distinct(DATEPART(year, ngay_nhap)) as t from phieu_nhap", comboBoxQuy, "t", "t");
            dbAccess.FillCombo("select distinct(DATEPART(year, ngay_nhap)) as t from phieu_nhap", comboBoxPhieu, "t", "t");
            DataSet dataSet1 = new DataSet();
            SqlCommand commandQuy = new SqlCommand("ChiPhiNhapTheoQuy");
            //MessageBox.Show(comboBoxQuy.Text);
            commandQuy.Parameters.AddWithValue("@nam", comboBoxQuy.Text);
            dbAccess.pushDataSet(commandQuy, dataSet1);
            chart_doughnut.DataSource = dataSet1;
            chart_doughnut.Series["s1"].XValueMember = "Quy";
            chart_doughnut.Series["s1"].YValueMembers = "tongtien";

            DataSet dataSet2 = new DataSet();
            SqlCommand commandPhieu = new SqlCommand("ThongKePhieuTheoThang");
            //MessageBox.Show(comboBoxQuy.Text);
            commandPhieu.Parameters.AddWithValue("@nam", comboBoxPhieu.Text);
            dbAccess.pushDataSet(commandPhieu, dataSet2);
            chart_column.DataSource = dataSet2;
            chart_column.Series["Số lượng phiếu nhập"].XValueMember = "Thang";
            chart_column.Series["Số lượng phiếu nhập"].YValueMembers = "nhap";
            chart_column.Series["Số lượng phiếu xuất"].XValueMember = "Thang";
            chart_column.Series["Số lượng phiếu xuất"].YValueMembers = "xuat";
        }

        private void comboBoxQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataSet1 = new DataSet();
            SqlCommand commandQuy = new SqlCommand("ChiPhiNhapTheoQuy");
            //MessageBox.Show(comboBoxQuy.Text);
            commandQuy.Parameters.AddWithValue("@nam", comboBoxQuy.Text);
            dbAccess.pushDataSet(commandQuy, dataSet1);
            chart_doughnut.DataSource = dataSet1;
            chart_doughnut.Series["s1"].XValueMember = "Quy";
            chart_doughnut.Series["s1"].YValueMembers = "tongtien";
        }

        private void comboBoxPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataSet2 = new DataSet();
            SqlCommand commandPhieu = new SqlCommand("ThongKePhieuTheoThang");
            //MessageBox.Show(comboBoxQuy.Text);
            commandPhieu.Parameters.AddWithValue("@nam", comboBoxPhieu.Text);
            dbAccess.pushDataSet(commandPhieu, dataSet2);
            chart_column.DataSource = dataSet2;
            chart_column.Series["Số lượng phiếu nhập"].XValueMember = "Thang";
            chart_column.Series["Số lượng phiếu nhập"].YValueMembers = "nhap";
            chart_column.Series["Số lượng phiếu xuất"].XValueMember = "Thang";
            chart_column.Series["Số lượng phiếu xuất"].YValueMembers = "xuat";
        }
    }
}
