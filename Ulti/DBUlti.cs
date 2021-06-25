using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp1 {
    class DBUlti {

        readonly static string cs = "Data Source=DINHPHAM;Initial Catalog=ATM;Integrated Security=True";
       
        protected SqlConnection conn;
       
        public DBUlti() {
            conn = new SqlConnection(cs);
            if (conn.State != ConnectionState.Open)
                conn.Open();
           
        }
        
       


    }
}
