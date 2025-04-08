using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard
{
    public static class ConnectionConfig
    {
        // Azure SQL Server connection string
        // public static string ConnectionString = "Server=tcp:admindashboarddbserver.database.windows.net; Authentication = Active Directory Default; Database = AdminDashboard_db; Trust Server Certificate=True";

        // SenamileNdaba Computer Connection String
         public static string ConnectionString = "Data Source=SenamileNdaba;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";

        // SacredHeart Computer Connection String
        //public static string ConnectionString = "Data Source=SACREDHEART\\SQLEXPRESS;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";
    }
}
