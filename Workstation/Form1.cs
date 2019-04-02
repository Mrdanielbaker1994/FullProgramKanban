using ConfigurationFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workstation
{
    public partial class WorkstationForm : Form
    {
        public WorkstationForm()
        {


            /* 

                 This allows the Configuration solution to begin at start so the person can set their preferences

            */

            //var configFileProcess = new Process
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = "ConfigurationFile.exe"
            //    }
            //};
            //configFileProcess.Start();
            //configFileProcess.WaitForExit();



            /* 

            starting the workstation simulation program

            */

            InitializeComponent();





            


        }

        private void WorkstationForm_Load(object sender, EventArgs e)
        {




            PopulateEmployeeTypeForm();
            RefreshBinForm();
            /* This is to initially to call the configuration table and make it accessible via a data table */
            ReturnConfigTable.FillConfigTable();
            /* this will return the data table */
            //DataTable test = ReturnConfigTable.GetConfigTable;







        }

        public void InitializeProgramFlow()
        {
            Runner runner = new Runner();
            Builder builder = new Builder();




        }






        public void RefreshBinForm()
        {
            DALkanban workbin = new DALkanban();
            DataTable workbinDataTable = workbin.GetNumberItemsInBin();
            setBinColors(workbinDataTable);

        }

        public void setBinColors(DataTable workbinDataTable)
        {
            //HarnessClrBox.BackColor = Color.Red;
            //BezelClrBox.BackColor = Color.Red;
            //ReflectorClrBox.BackColor = Color.Red;
            //BulbClrBox.BackColor = Color.Red;

            //LensClrBox.BackColor = Color.Red;
            //HousingClrBox.BackColor = Color.Red;




            /* 

            this allows us to to change colors of the box from red, yellow and green to notify
            the user of the workstation whether the bins are nearly depleted

            */




            //if()
            //{
            //    HousingClrBox.BackColor = Color.Green;

            //}
            //else if()
            //{
            //    HousingClrBox.BackColor = Color.Orange;

            //}
            //else
            //{
            //    HousingClrBox.BackColor = Color.Red;

            //}



            //if ()
            //{
            //    LensClrBox.BackColor = Color.Green;

            //}
            //else if ()
            //{
            //    LensClrBox.BackColor = Color.Orange;

            //}
            //else
            //{
            //    LensClrBox.BackColor = Color.Red;


            //}


            //if ()
            //{
            //    BulbClrBox.BackColor = Color.Green;

            //}
            //else if ()
            //{
            //    BulbClrBox.BackColor = Color.Orange;

            //}
            //else
            //{
            //    BulbClrBox.BackColor = Color.Red;

            //}

            //if ()
            //{
            //    HarnessClrBox.BackColor = Color.Green;

            //}
            //else if ()
            //{
            //    HarnessClrBox.BackColor = Color.Orange;

            //}
            //else
            //{
            //    HarnessClrBox.BackColor = Color.Red;

            //}

            //if ()
            //{
            //    BezelClrBox.BackColor = Color.Green;

            //}
            //else if ()
            //{
            //    BezelClrBox.BackColor = Color.Orange;

            //}
            //else
            //{
            //    BezelClrBox.BackColor = Color.Red;

            //}

            //if ()
            //{
            //    ReflectorClrBox.BackColor = Color.Green;

            //}
            //else if ()
            //{
            //    ReflectorClrBox.BackColor = Color.Orange;

            //}
            //else
            //{
            //    ReflectorClrBox.BackColor = Color.Red;

            //}


        }


        public void PopulateEmployeeTypeForm()
        {
            EmployeeClass employeeGenerate = new EmployeeClass();
            string valueToPrint = employeeGenerate.returnEmployeeType();
            EmployeeTypeLbl.Text = "Employee Type: " + valueToPrint;
        }

    }
}
