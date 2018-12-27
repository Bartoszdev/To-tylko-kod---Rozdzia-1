using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Practice_1
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;

        public ScaryScary(int numberOfScaryThings) : base("napis")
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        public string ScaryThingIHave { get { return numberOfScaryThings + "pająków"; } }

        public void ScareLittleChildren()
        {
            throw new NotImplementedException();
        }
    }
}
