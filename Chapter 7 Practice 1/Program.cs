using System;

namespace Chapter_7_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy Guy = new TallGuy { Name = "Adam", Height = 190 };
            Guy.TalkToYourself();
        }
    }
}
