using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    class functionShare
    {
       
        DataTable dataTable;
        SqlCommand comman;
        dbAccess database= new dbAccess();
        string query;
        public functionShare(int sever)
        {
            database.pickSever(sever);
        }
        public void autoID(Label primaryKey,string name_table)
        {
            query = "SELECT MAX(id) AS MAX FROM "+name_table;
            comman = new SqlCommand(query);
            dataTable = new DataTable();
            database.pushDataTable(comman, dataTable);
            int id = 0;
            if (dataTable.Rows[0]["MAX"].ToString() == "")
                id = 1;
            else
                id = Convert.ToInt32(dataTable.Rows[0]["MAX"].ToString()) + 1;
            primaryKey.Text = id.ToString();
        }
        public void loadGridView(string name_table, DataGridView gridView)
        {
            query = "SELECT * FROM " + name_table;
            comman = new SqlCommand(query);
            database.pushGridview(comman, gridView);
        }
        public bool isNumber(string pValue)
        {
            if (pValue == "")           
                return false;           
            else
            {
                foreach (Char c in pValue)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
        }
        public void textboxLeave(TextBox tb, string text)
        {
            if (tb.Text == "")
            {
                tb.Text = text;
                tb.ForeColor = Color.Silver;
            }
        }
        public void textboxEnter(TextBox tb, string text)
        {
            if (tb.Text == text)
            {
                tb.Clear();
                tb.ForeColor = Color.Black;
            }
        }
        public string Nvarchar(string input)
        {
            input = "N'" + input + "'";
            return input;
        }
     
        public void insert(string name_table,string colum_type,string c1,string c2,string c3,string c4,string c5,string c6)
        {
           
            string query = "SET IDENTITY_INSERT "+ name_table +" ON;" +
           "INSERT INTO " + name_table + " ( " + colum_type + ") " +
    "VALUES (" + c1 + "," + c2 + "," + c3 + ", " + c4 + ", " + c5 + "," + c6 + ")   "
             + "SET IDENTITY_INSERT " + name_table + " OFF;";
            comman = new SqlCommand(query);
            database.editDB(comman);
        }
        public void insert(string name_table, string colum_type, string c1, string c2, string c3, string c4, string c5)
        {

            string query = "SET IDENTITY_INSERT " + name_table + " ON;" +
           "INSERT INTO " + name_table + " ( " + colum_type + ") " +
    "VALUES (" + c1 + "," + c2 + "," + c3 + ", " + c4 + ", " + c5 +  ")   "
             + "SET IDENTITY_INSERT " + name_table + " OFF;";
            comman = new SqlCommand(query);
            database.editDB(comman);
        }
        public void insert(string name_table, string colum_type, string c1, string c2, string c3, string c4)
        {

            string query = "SET IDENTITY_INSERT " + name_table + " ON;" +
           "INSERT INTO " + name_table + " ( " + colum_type + ") " +
    "VALUES (" + c1 + "," + c2 + "," + c3 + ", " + c4 +  ")   "
             + "SET IDENTITY_INSERT " + name_table + " OFF;";
            comman = new SqlCommand(query);
            database.editDB(comman);
        }
        public void insert(string name_table, string colum_type, string c1, string c2, string c3 )
        {

            string query = "SET IDENTITY_INSERT " + name_table + " ON;" +
           "INSERT INTO " + name_table + " ( " + colum_type + ") " +
    "VALUES (" + c1 + "," + c2 + "," + c3 + ")   "
             + "SET IDENTITY_INSERT " + name_table + " OFF;";
            comman = new SqlCommand(query);
            database.editDB(comman);
        }

        public string where(string name_id,string id)
        {
            string x= " WHERE " + name_id + "=" + id;
            return x;
        }
        public string where(string name_id, string id, string name_id_2, string id_2)
        {
            string x = " WHERE " + name_id + "=" + id +" AND " + name_id_2 + "=" + id_2;
            return x;
        }
        public void update(string name_table, string colum_type, string c0, string c1, string c2, string c3, string c4,string where)
        {
            string[] arr1 = colum_type.Split(',');
            string update = "UPDATE " + name_table + " SET " + arr1[0] + "=" + c0 +
            " ," + arr1[1] + "= " + c1 + " ," + arr1[2] + "= " + c2 +
             " ," + arr1[3] + "= " + c3 + " ," + arr1[4] + "= " + c4 + where;
            comman = new SqlCommand(update);
            database.editDB(comman);
        }
        public void update(string name_table, string colum_type, string c0, string c1, string c2, string where)
        {
            string[] arr1 = colum_type.Split(',');
            string update = "UPDATE " + name_table + " SET " + arr1[0] + "=" + c0 +
            " ," + arr1[1] + "= " + c1 + " ," + arr1[2] + "= " + c2 + where;
            comman = new SqlCommand(update);
            database.editDB(comman);
        }
        /*
         * làm việc với gridview
         * 24
           DataGridViewRow row = (DataGridViewRow)gridView2.Rows[0].Clone();
            row.Cells[0].Value = 1;
            row.Cells[1].Value = 1;
            row.Cells[2].Value = 1;
            row.Cells[3].Value = "gói";
            gridView2.Rows.Add(row);    (put data into gridview
            this.dataGridView1.Rows.Add("five", "six", "seven","eight");
            this.dataGridView1.Rows.Insert(0, "one", "two", "three", "four");
            gridView2.Rows.Count  //đếm tổng row ( bắt đầu từ 1 not 0)
            gridView.Rows[2].Cells[2].Value.ToString(); //get data from gridview
         */
    }
}
