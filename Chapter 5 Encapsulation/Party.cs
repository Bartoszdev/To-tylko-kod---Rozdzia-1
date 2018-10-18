using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Encapsulation
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public int AddedCostForPerson
        {
            get
            {
                if (NumberOfPeople > 12)
                    return 100;
                return 0;
            }
        }
    }
}
