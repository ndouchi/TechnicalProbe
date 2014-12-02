using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Enums;

namespace BestBuy.TechnicalProbe.FizzBuzz.Common.Utility
{
    public class Display
    {
        //        public void RecordToFile(FileSystemInfo fsi, string str)
        //        {
        ////            Console.WriteLine(str);
        //        }
        public static void RecordToFile(string str)
        {
            Console.WriteLine(str);
        }
        //public static void DisplayMessageOnConsole(string str)
        //{
        //    Console.WriteLine(str);
        //}
        public static void DisplayMessageOnConsole(string str, DisplayOptions displayOptions = DisplayOptions.DisplayNewLine)
        {
            switch (displayOptions)
            {
                case DisplayOptions.NoNewLine:
                    Console.Write(str);
                    break;
                case DisplayOptions.DisplayNewLine:
                    Console.WriteLine(str);
                    break;
                default:
                    break;
            }
        }
    }
}
