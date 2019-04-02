using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workstation
{
    class Tester
    {


        public void TestLamps()
        {
            DALkanban tester = new DALkanban();
            tester.TestLampsRowDAL();
        }


    }
}
