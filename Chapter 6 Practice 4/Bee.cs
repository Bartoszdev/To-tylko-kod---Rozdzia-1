using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Practice_4
{
    public class Bee
    {
        public Bee(double weightMg)
        {
            this.WeightMg = weightMg;
        }
        public const double HoneyUnitsConsumedPerMg = 0.25;
        public double WeightMg { get; set; }
        virtual public double HoneyConsumptionRate()
        {

            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
