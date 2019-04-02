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






    public void TestLampsRowDAL()
    {
        try
        {
            using (var cmd = new SqlCommand("STORED_PROCEDURE_NAME", ConnectionStringKanban.Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                //  cmd.Parameters.Add("@ruleName", SqlDbType.VarChar).Value = rule;


                ConnectionStringKanban.Conn.Open();
                cmd.ExecuteNonQuery();
                ConnectionStringKanban.Conn.Close();
                //retValue = true;
            }
        }
        catch (Exception ex)
        {
            throw ex;

        }
    }

















        public void AddNewLampRowDAL()
    {
            try
            {
                using (var cmd = new SqlCommand("STORED_PROCEDURE_NAME", ConnectionStringKanban.Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                  //  cmd.Parameters.Add("@ruleName", SqlDbType.VarChar).Value = rule;


                    ConnectionStringKanban.Conn.Open();
                    cmd.ExecuteNonQuery();
                    ConnectionStringKanban.Conn.Close();
                    //retValue = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }






        public DataTable SubtractItemsInBinDAL()
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











        public DataTable GetNumberItemsInBinDAL()
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
