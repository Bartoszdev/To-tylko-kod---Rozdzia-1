using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Encapsulation
{
    class BirthdayParty : Party
    {
        Party party = new Party();
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations  { get; set; }
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
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.0M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.0M;

            return costOfDecorations;
        }

        public decimal Cost
        {
           
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                party.NumberOfPeople = NumberOfPeople;
                totalCost += CostOfFoodPerPerson * NumberOfPeople + party.AddedCostForPerson;
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
