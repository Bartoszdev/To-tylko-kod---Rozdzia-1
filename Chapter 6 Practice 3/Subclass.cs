using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_6_Practice_3
{
    public class Subclass : MyBaseClass
    {
        public Subclass(string baseClassNeedsThis, int anotherValue)
            : base(baseClassNeedsThis)
        {
            MessageBox.Show("To jest klasa pochodna: " + baseClassNeedsThis + " i " + anotherValue);
        }
        
    }
}
