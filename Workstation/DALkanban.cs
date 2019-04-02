using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workstation
{
    class DALkanban
    {


































        public DataTable GetNumberItemsInBin()
        {
            DataTable dt = new DataTable();
            const string query = @"";
            try
            {
                using (var command = new SqlCommand(query, ConnectionStringKanban.Conn))
                {
                    ConnectionStringKanban.Conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    ConnectionStringKanban.Conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return dt;

        }
    }
}
