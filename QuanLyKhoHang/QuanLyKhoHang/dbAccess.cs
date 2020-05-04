using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    class dbAccess
    {
        public static string strConn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=TTCSDL;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(strConn);
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlCommand command = new SqlCommand();

        //tạo kết nối
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConn;
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void readDataToAdapter(string query, DataTable data)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //lấy dữ liệu vào gridview, hoặc dùng chạy câu lệnh 
        public void GetData(string query, DataGridView grid, DataTable data)
        {
            try
            {
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                grid.DataSource = data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //đổ dữ liệu vào 1 combo box
        public static void FillCombo(string query, ComboBox cbo, string ma, string ten)
        {
            adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
            cbo.DataSource = table;
        }
        // lấy dữ liệu trong 1 cell của table
        public static string GetFieldValues(string query)
        {
            DataTable data = new DataTable();
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);
            DataRow dr = data.Rows[0];
            string s = dr[0].ToString();
            return s;
        }
        //kiểm tra một row data đã tồn tại trong table chưa
        public static bool CheckKey(string query)
        {
            adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            if (data.Rows.Count > 0)
                return true;
            else return false;
        }
    }
}
