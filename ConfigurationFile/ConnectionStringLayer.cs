/*
* FILE : 
* PROJECT : 
* PROGRAMMER : Daniel Baker & Irina Alexandru
* FIRST VERSION : 2019-03-18
* DESCRIPTION :  This file contains the logic to allow the user of this system
* to access their connection string. It is to simply keep the program more modular. The connection
* string is being accessed from the App.Config file and is configured to connect to Daniel Baker's 
* home system, so this will require making edis for it to work.
*/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

namespace ConfigurationFile
{
    public static class ConInfo
    {
        private static readonly string ConnString = ConfigurationManager.ConnectionStrings["ConfigFile"].ConnectionString;

        private static readonly SqlConnection conn = new SqlConnection(ConnString);


        public static string publicConnString { get => ConnString; }

        public static SqlConnection Conn { get => conn; }

        

    }
}
