using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    }
}
