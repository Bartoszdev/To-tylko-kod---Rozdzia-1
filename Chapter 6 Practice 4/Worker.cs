using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Practice_4
{
    class Worker
    {
        private string currentJob = String.Empty;
        public string CurrentJob
        {
            get
            {
                return currentJob; 
            }
        }
        
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            } 
        }
        private string[] jobsICanDo;
        private int shiftsToWork { get; set; }
        private int shiftsWorked { get; set; }
        public Worker(string[] jobsICanDo)
        {

        }

        public bool DoThisJob()
        {

        }
        public bool WorkOneShift()
        {

        }

        
        
        
    }
}
