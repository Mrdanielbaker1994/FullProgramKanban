using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Workstation
{
    public static class ConnectionStringKanban
    {
        private static string ConnString = ConfigurationManager.ConnectionStrings["ConfigurationTool"].ConnectionString;
        private static SqlConnection myConn = new SqlConnection(ConnString);


        public static string publicConnString { get => ConnString; }
        public static SqlConnection Conn { get => myConn; }
    }
}
