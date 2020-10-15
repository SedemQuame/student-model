using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Model
{
    class Timer:IDisposable
    {
        //String message;
            
        DateTime startTime;
        DateTime endTime;
        //TimeSpan timeSpan;   
        TimerDelegate alert;

        //Old Constructor  ("without a delegate")
        //public Timer(string message)
        //{
        //    this.startTime = DateTime.Now;
        //}

        //New constructor ("with delegate.")
        public Timer(TimerDelegate alertFunc)
        {
            this.startTime = DateTime.Now;
            this.alert = alertFunc;
        }

        //Old Constructor implementation ("without a delegate")
        //public void dispose()
        //{
        //    this.endtime = datetime.now;
        //    timespan = starttime - endtime;
        //    console.error.writeline($"interval format [hh:mm:ss:fffff] for application: {timespan.tostring()}");
        //    console.error.writeline($"interval format [fffff] for application: {timespan.totalmilliseconds}");
        //    close();
        //}

        //New constructor implementation ("with delegate.")
        public void Dispose()
        {
            this.alert(this.startTime, this.endTime);
            Close();
        }

        public void Close()
        {
            //Release resources
            System.GC.SuppressFinalize(this);
        }

    }
}
