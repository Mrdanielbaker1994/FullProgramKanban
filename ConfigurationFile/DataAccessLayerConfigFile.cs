using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConfigurationFile
{
    public class DataAccessLayerConfigFile
    {

        public DataTable GetConfigTable()
        {
            DataTable dt = new DataTable();
            const string query = @"select ID, configInfo_key as 'Setting Name', configInfo_Value as 'Setting Value', activeStatus as 'Enabled / Disabled' from ConfigurationTable";
            try
            {
                using (var command = new SqlCommand(query, ConInfo.Conn))
                {
                    ConInfo.Conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    ConInfo.Conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }


        public bool AddRowToTable(string rule, string value, bool isOn)
        {
            bool retValue = false;

            try
            {
                using (var cmd = new SqlCommand("AddToConfigTable", ConInfo.Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ruleName", SqlDbType.VarChar).Value = rule;
                    cmd.Parameters.Add("@ruleDescription", SqlDbType.VarChar).Value = value;
                    cmd.Parameters.Add("@isOn", SqlDbType.Bit).Value = isOn;
                    
                    ConInfo.Conn.Open();
                    cmd.ExecuteNonQuery();
                    ConInfo.Conn.Close();
                    retValue = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return retValue;
        }

        public bool EditRowInTable(string rule, string value, bool isOn, int id)
        {
            bool retValue = false;

            try
            {
                using (var cmd = new SqlCommand("EditRowInConfigTable", ConInfo.Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idRowToEdit", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@newSettingName", SqlDbType.VarChar).Value = rule;
                    cmd.Parameters.Add("@newSettingValue", SqlDbType.VarChar).Value = value;
                    cmd.Parameters.Add("@isOn", SqlDbType.Bit).Value = isOn;

                    ConInfo.Conn.Open();
                    cmd.ExecuteNonQuery();
                    ConInfo.Conn.Close();
                    retValue = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return retValue;
        }

    }
}
