using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Practice_1
{
     class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
        public string FunnyThingIHave { get { return "Cześć dzieciaki. Mam " + funnyThingIHave; } }

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
