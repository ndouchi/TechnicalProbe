using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Interfaces;

namespace BestBuy.TechnicalProbe.FizzBuzz.Model
{
    public class Divider : IDivider
    {
        private int lowNumber;
        private int highNumber;
        public Divider(int lowNum, int highNum)
        {
            if (lowNum <= 0 || highNum <= 0)
            {
                throw new Exception("Divider Constructor parameters must be values above zero.");
            }

            lowNumber = lowNum;
            highNumber = highNum;
        }

        public string Divide(INObject nObject)
        {
            string output = string.Empty;

            if (nObject.IsNumber())
            {
                int? num = nObject.GetNumericValue();
                if (num != null)
                {
                    output = string.Concat(this.DivideByLowNumber((int)num), this.DivideByHighNumber((int)num));

                    if (string.Empty == output)
                    {
                        output = string.Concat("Divided ", num, " by ", lowNumber, "\nDivided ", num, " by ", highNumber);
                    }
                }
            }
            else
                output = "Invalid Item.";

            return output;
        }

        private string DivideByLowNumber(int num)
        {
            string returnValue = string.Empty;
            if (num % lowNumber == 0)
                returnValue = "Fizz";

            return returnValue;
        }
        private string DivideByHighNumber(int num)
        {
            string returnValue = string.Empty;
            if (num % highNumber == 0)
                returnValue = "Buzz";

            return returnValue;
        }
    }
}