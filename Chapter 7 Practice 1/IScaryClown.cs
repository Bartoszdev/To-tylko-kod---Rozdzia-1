using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Practice_1
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
