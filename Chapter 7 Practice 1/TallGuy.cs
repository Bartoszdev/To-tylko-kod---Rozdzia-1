using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Practice_1
{
    public class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave => "duże buty";

        public void Honk()
        {
            Console.WriteLine("Tut Tuut!");
        }

        public void TalkToYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu.");
        }

    }
}
