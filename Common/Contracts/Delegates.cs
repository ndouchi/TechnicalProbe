using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Enums;

namespace BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts
{
    public class Delegates
    {
        //        public delegate void PrintDelegate(String str);
        public delegate void DisplayDelegate(String str, DisplayOptions displayOptions = DisplayOptions.DisplayNewLine);
        //   public delegate void PrintDelegate(FileSystemInfo fsi, String str);
    }
}
