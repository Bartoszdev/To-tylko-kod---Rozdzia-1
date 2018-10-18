using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClass
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        private int feedMultiplayer;
        public int FeedMultiplayer { get { return feedMultiplayer; } }

        public Farmer(int numberOfCows, int feedMultiplayer)
        {
            this.feedMultiplayer = feedMultiplayer;
            NumberOfCows = numberOfCows;
        }

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplayer;
            }
        }
    }
}
