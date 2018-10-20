using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public string Picture { get; set; }
        public int Food { get; set; }
        public int Hunger { get; set; }
        public int Boundaries { get; set; }
        public int Location { get; set; }

        public virtual void MakeNoise()
        {

        }
        public virtual void Eat()
        {

        }
        public void Sleep()
        {

        }
        public void Roam()
        {

        }
    }
}
