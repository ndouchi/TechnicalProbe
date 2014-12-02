using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Interfaces
{
    public interface INObject
    {
        string ObjectValue { get; set; }
        bool IsNumber();

        int? GetNumericValue();
    }
}
