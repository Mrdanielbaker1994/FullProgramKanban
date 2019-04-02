using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workstation
{
    class EmployeeClass
    {

        private String[] SkillLevelArray = new string[3] { "Skilled", "Junior", "Unskilled" };


        public String[] skillLevelArray    // the Name property
        {
            get
            {
                return SkillLevelArray;
            }
        }


        public string returnEmployeeType()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 3); 
            return SkillLevelArray[i];
        }

    }
}
