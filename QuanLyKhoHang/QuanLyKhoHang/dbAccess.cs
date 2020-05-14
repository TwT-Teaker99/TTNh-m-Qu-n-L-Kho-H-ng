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
        public static string strConn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True";              
        private static string VuSever =
           "Data Source = DESKTOP-VES4POV\\MSSQLSERVER03;Database =QuanLyKhoHang; Integrated Security=SSPI;";


        public static SqlConnection connection = new SqlConnection(strConn);


        private static SqlDataAdapter adapter;
        private static SqlCommand command;

        public void pickSever(int choice)
        {
            if (choice ==1)
            {
                connection= new SqlConnection(VuSever);
            }
            if (choice==2)
            {
                connection = new SqlConnection(strConn);
            }
        }//chọn sever cho khớp từng máy riêng


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
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                //command.Dispose();
                //adapter.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //lấy dữ liệu vào gridview, hoặc dùng chạy câu lệnh 
        public static void GetData(string query, DataGridView grid)
        {
            try
            {
                DataTable data = new DataTable();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                grid.DataSource = data;
                //adapter.Dispose();
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
            //adapter.Dispose();
        }

        //đổ dữ liệu vào dataCollection để dùng suggest combobox
        public static void FillColl(AutoCompleteStringCollection dataColl,string query)
        {
            DataSet ds = new DataSet();
            command = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            //adapter.Dispose();
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                dataColl.Add(row[0].ToString());
            }
        }
        // lấy dữ liệu trong 1 cell của table
        public static string GetFieldValues(string query)
        {
            DataTable data = new DataTable();
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);
            DataRow dr = data.Rows[0];
            string s = dr[0].ToString();
            //adapter.Dispose();
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


        public void pushGridview(string query, DataGridView gridview)//đẩy dữ liệu vào gridview 
        {
            
            try
            {
                connection.Open();
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;
                SqlDataReader dataread = dbCommand.ExecuteReader();
                if (dataread.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = dataread;
                    gridview.DataSource = source;                 
                }
                else
                {
                    gridview.Rows.Clear();
                    gridview.Refresh();
                }
              
                DataTable data = new DataTable();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                gridview.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
     
        public void pushGridview(string query, DataGridView gridview)//đẩy dữ liệu vào gridview 
        {

            try
            {
                connection.Open();

                DataTable data = new DataTable();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                gridview.DataSource = data;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();

            }
        }
        //public void pushGridview(string query, DataGridView gridview)//đẩy dữ liệu vào gridview 
        //{
            
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand dbCommand = new SqlCommand(query);
        //        dbCommand.Connection = connection;
        //        dbCommand.CommandType = CommandType.Text;
        //        SqlDataReader dataread = dbCommand.ExecuteReader();
        //        if (dataread.HasRows)
        //        {
        //            BindingSource source = new BindingSource();
        //            source.DataSource = dataread;
        //            gridview.DataSource = source;                 
        //        }
        //        else
        //        {
        //            gridview.Rows.Clear();
        //            gridview.Refresh();
        //        }
              
        //        DataTable data = new DataTable();
        //        adapter = new SqlDataAdapter(query, connection);
        //        adapter.Fill(data);
        //        gridview.DataSource = data;
             
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        public int editDB(SqlCommand dbCommand)//chỉnh sửa dữ liệu trong dataBase ( use for insert+delete)
        {
            try
            {
                connection.Open();
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;
                return dbCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

        }
        public bool SelectHasRow(string query)
        {
            command = new SqlCommand(query);
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                SqlDataReader dataread = command.ExecuteReader();
                if (dataread.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
        }




    }
}

