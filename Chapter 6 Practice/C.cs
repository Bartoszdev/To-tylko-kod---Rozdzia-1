using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Practice
{
   public class C : B
    {
        public override string m3()
        {
            return "C m3, " + (ivar + 6);
        }
    }
}
