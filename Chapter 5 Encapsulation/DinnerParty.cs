using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Encapsulation
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
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

        public override decimal Cost
        {
             get {
                decimal TotalCost = base.Cost;
                TotalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;

                if (HealthyOption)
                    return TotalCost * 0.95M;
                return TotalCost;
            }
            
        }

    }
}
