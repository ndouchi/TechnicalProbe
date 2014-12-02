using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Interfaces;

namespace BestBuy.TechnicalProbe.FizzBuzz.Model
{
    public class NObject : INObject
    {
        private string objectValue;
        private int numericValue;

        public string ObjectValue
        {
            get
            {
                return objectValue;
            }
            set
            {
                objectValue = value;
            }
        }

        public bool IsNumber()
        {
            bool isNumber = false;
            if (int.TryParse(objectValue, out numericValue))
                isNumber = true;
            return isNumber;
        }
        public int? GetNumericValue()
        {
            bool isNumber = int.TryParse(objectValue, out numericValue);
            { }
            return numericValue;
        }
        public NObject(string value)
        {
            this.objectValue = value;
        }
    }
}