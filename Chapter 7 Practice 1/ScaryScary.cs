using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Practice_1
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;

        public ScaryScary(string funnyThingIHave ,int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        public string ScaryThingIHave { get { return "Mam " + numberOfScaryThings + " pająków"; } }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Nie możesz mieć mojego " + base.funnyThingIHave);
        }
    }
}
