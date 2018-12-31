using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Practice_2
{
    abstract class Picasso : Nose
    {
        public virtual int Ear()
        {
            return 7;
        }
        public Picasso(string face)
        {
            this.face = face;
        }
        public virtual string Face
        {
            get { return face; } 
        }
        string face;
    }
}
