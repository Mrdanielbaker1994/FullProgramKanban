using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workstation
{
    class Builder
    {





        public void AddNewLampRow()
        {
            DALkanban execute = new DALkanban();
            execute.AddNewLampRowDAL();

        }
        


        public void CheckIfTrayFull(int lampsInTray)
        {
            if(lampsInTray > 60)
            {
                Tester test = new Tester();
            }
            else
            {

            }

        }















    }
}
