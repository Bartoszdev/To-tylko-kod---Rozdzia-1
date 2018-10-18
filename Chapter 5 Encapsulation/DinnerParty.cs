using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Encapsulation
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {

        }
      
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15) + 50.0M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.0M;
            }
            return costOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.0M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.0M;
            }
            return costOfBeveragesPerPerson;
        }

        public decimal Cost()
        {
            decimal TotalCost = (CalculateCostOfDecorations() + CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople;

            if (HealthyOption)
                return TotalCost * 0.95M;
            return TotalCost;

            
        }

    }
}
