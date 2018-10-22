using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Parctice_2
{
    public class Boat
    {
        private int length;
        public int getLength()
        {
            return length;
        }
        public void setLength(int len)
        {
            length = len;
        }

        public virtual string move()
        {
            return "dryfuje  ";
        }
    }
}
