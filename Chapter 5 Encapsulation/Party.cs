using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Encapsulation
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public bool FancyDecorations { get; set; }
        public int NumberOfPeople { get; set; }
        public virtual decimal Cost
        { get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += NumberOfPeople * CostOfFoodPerPerson;
                totalCost += AddedCostForPerson;
              
                return totalCost;
                
            }
        }
        public int AddedCostForPerson
        {
            get
            {
                if (NumberOfPeople > 12)
                    return 100;
                return 0;
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
    }
}
