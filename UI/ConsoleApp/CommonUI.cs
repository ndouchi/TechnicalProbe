using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BestBuy.TechnicalProbe.FizzBuzz.Common.Utility;

namespace BestBuy.TechnicalProbe.FizzBuzz.UI.ConsoleApp
{
    public static class CommonUI
    {
        public static string ReadAppSetting(string key)
        {
            if (null == key || string.Empty == key.Trim())
            {
                throw new ArgumentNullException("ERROR: appSetting key cannot cannon be null or empty.  Cannot extract an appSetting for an empty-key value.");
            }

            string returnResult = string.Empty;

            #region try-catch key-value extraction
            try
            {
                var appSetting = ConfigurationSettings.AppSettings;
                returnResult = appSetting[key] ?? string.Empty;

                if (string.Empty == returnResult.Trim())
                {
                    returnResult = String.Format("ERROR: appSetting configuration value was either empty or mere white spaces");
                }
            }
            catch (ConfigurationException ex)
            {
                // Insert Logger call here. String.Format("ERROR: {0} ! ConfigurationException - Invalid Data");
                // Log call location
            }
            catch (Exception ex)
            {
                // Insert Logger call here: String.Format("ERROR: {0} ! SystemException - Invalid Data");
                // Log call location
            }
            #endregion try-catch key-value extraction

            return returnResult;
        }
        
        /// <summary>
        /// the return value cannot be equal to this value*/
        /// </summary>
        /// <param name="lowerBound">2</param>
        /// <param name="promptMsg">Enter a number: </param>
        /// <returns>6</returns>
        public static int GetAPositiveIntegerFromUserInput(int rangeLowerBound, string promptMsg)
        {
            if (null == promptMsg)
            {
                throw new ArgumentNullException("ERROR: promptMsg cannot be null.");
            }

            int num = 0;
            string inputStr = string.Empty;

            while (num < rangeLowerBound)
            {
                Console.Write(promptMsg);

                try
                {
                    inputStr = Console.ReadLine();
                    int.TryParse(inputStr, out num);
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
            return num;
        }
    }
}
