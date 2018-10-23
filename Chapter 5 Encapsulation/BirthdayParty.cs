using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Encapsulation
{
    class BirthdayParty : Party
    {
        public string CakeWriting { get; set; }
        private int actualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                return CakeWriting.Length;
            }      
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            return 40;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 20)
                return  16;
            return  40;
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecoration, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecoration;
            CakeWriting = cakeWriting;
        }
        public bool CakeWritingTooLong
        {
            get
                {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                return false;
            }
        }
        

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 20)
                     cakeCost = 40.0M + actualLength * 0.25M;
                else
                     cakeCost = 75.0M + actualLength * 0.25M;

                return cakeCost + totalCost;
            }
        }

    }
}
