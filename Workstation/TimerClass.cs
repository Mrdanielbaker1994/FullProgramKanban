﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Workstation
{
    public static  class TimerClass
    {

        private static System.Timers.Timer aTimer;
        private static string TimeInterval;
        public static string SetTimeInterval()
        {
            DataTable configDataTable = ReturnConfigTable.GetConfigTable;
            /* access value from data table */
            return TimeInterval;
        }


        public static string GetTimeInterval
        {
            get => TimeInterval;

        }







        private static void SetTimer()
        {



            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }


        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Debug.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);


            /*
             * 
             *   call Runner to check time
             * 
             */
            
            
            
            



        }




    }
}
