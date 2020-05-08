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
    public partial class NhaCungCap : Form
    {
        dbAccess database = new dbAccess();
        
        public NhaCungCap()
        {
            InitializeComponent();
            database.pickSever(1);
        }
      

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
          
            string query = "SELECT * FROM nha_cung_cap";
            SqlCommand comman = new SqlCommand(query);
            database.pushGridview(comman, gridView);
        }
    }
}
