using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Author: Nour Douchi
/// 
using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Interfaces;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Enums;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Utility;
using BestBuy.TechnicalProbe.FizzBuzz.Model;

namespace BestBuy.TechnicalProbe.FizzBuzz.UI.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lowNumber = 0;
            int highNumber = 0;
            Divider divider;
            
            NObjects nObjects = new NObjects();

            lowNumber = CommonUI.GetAPositiveIntegerFromUserInput(AppConsts.numericalInputLowerBound, AppConsts.lowNumerPrompt);

            highNumber = CommonUI.GetAPositiveIntegerFromUserInput(lowNumber + 1, AppConsts.highNumberPrompt);
            PopulateNObjects(nObjects);

            try
            {
                Delegates.DisplayDelegate display = Display.DisplayMessageOnConsole;
                divider = new Divider(lowNumber, highNumber);
                nObjects.RunDivider(divider, display);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Hit any key to exit this program...");
            Console.ReadKey();
        }
        private static void PopulateNObjects(NObjects nObjects)
        {
            string userNObjectInput = null;
            while (null == userNObjectInput)
            {
                Console.Write("Enter a number or an alphanumeric value or type END to stop: ");
                userNObjectInput = Console.ReadLine();
                if (userNObjectInput.ToUpper() == "END")
                    break;
                else
                    nObjects.Add(userNObjectInput);

                userNObjectInput = null;
            }
        }

    }
}
