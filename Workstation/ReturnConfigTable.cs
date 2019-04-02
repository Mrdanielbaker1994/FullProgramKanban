using ConfigurationFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workstation
{
    public static class ReturnConfigTable
    {
        private static  DataTable ConfigDataTable;
        public static void FillConfigTable()
        {

            /* 

            we are getting the configuration table from the other solution named 'ConfigurationFile'

            */


            DataAccessLayerConfigFile PtrConfigSolution = new DataAccessLayerConfigFile();
            ConfigDataTable = PtrConfigSolution.GetConfigTable();
        }
       
        public static DataTable GetConfigTable
        {
            get
            {
                return ConfigDataTable;
            }

        }














    }
}
