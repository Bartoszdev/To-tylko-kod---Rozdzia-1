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
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job , int shifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
                for (int i = 0; i < jobsICanDo.Length; i++)
                    if (jobsICanDo[i].Contains(job))
                    {
                        currentJob = job;
                        this.shiftsToWork = shifts;
                        shiftsWorked = 0;
                        return true;
                    }
                return false;
        }
        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(CurrentJob))
                return false;
            shiftsWorked++;
            if(shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = String.Empty;
                return true;
            }
            return false;
        }
    }
}
