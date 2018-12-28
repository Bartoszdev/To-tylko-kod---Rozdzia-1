using System;

namespace Chapter_7_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FunnyFunny someFunnyClown = new ScaryScary("duże buty", 35);

            IScaryClown someOtherScaryClown;
            if (someFunnyClown is ScaryScary)
            {
                someOtherScaryClown = someFunnyClown as ScaryScary;
                someOtherScaryClown.Honk();
                Console.ReadKey();
            }
            
        }
    }
}
