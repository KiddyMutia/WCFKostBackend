using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WCFKostBackend
{
    class Koneksi
    {
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(

                "Data Source = USER\\MUTIAAYUDIANITA;" +
                "Initial Catalog = RentHouseBackend;" +
                "User Id = andi; Password = andijuga"
             );
            return con;
        }
    }
}
