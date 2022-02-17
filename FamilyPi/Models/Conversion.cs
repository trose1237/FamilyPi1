using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyPi.Models
{
    public enum Volume
    {
        Cups, 
        Tablespoons,
        Teaspoons,
        Quarts,
        FluidOunces,
        Mililiter,
        Liters,
        Gallons,
        Pints
    }
    public class Conversion
    {
        public static double[] conversionRate = new double[]
        {
            1, //cups
            16, //tablespoons
            48, //teaspoons
            0.25, //quarts
            8, //ounces
            236.588, //mililiters
            0.236588, //liters
            0.0625, //gallons
            0.5 //pints
        };

        public double ConversionMethod(double valueToConvert, Volume from, Volume to)
        {
            double valueToWorkIn;

            if(from == Volume.Cups)
            {
                valueToWorkIn = valueToConvert;
            }
            else
            {
                valueToWorkIn = valueToConvert / conversionRate[(int)from];
            }

            if(to != Volume.Cups)
            {
                valueToWorkIn = valueToConvert * conversionRate[(int)to];
            }

            return valueToWorkIn;
        }
    }
}
