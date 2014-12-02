using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Enums;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Interfaces;

namespace BestBuy.TechnicalProbe.FizzBuzz.Common.Utility
{
    /// <summary>
    /// Logger hasn't been designed as a service, yet.
    /// </summary>
    public sealed class Logger : ILog
    {
        //private static readonly Lazy<ILog> _instance = new Lazy<ILog>(valueFactory: () => new Logger(), isThreadSafe: true); 
        private static volatile Logger _instance;
        private static object _lockMutex = new object();
        //private static int _processID;

        private Logger() { }

        public static Logger GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockMutex)
                    {
                        if (_instance == null)
                            _instance = new Logger();
                    }
                }

                return _instance;
            }
        }

        //private Delegates.PrintDelegate recordFunction; // Support for variety of logging methods.
        
        //public int ProcessID
        //{
        //    get { return _processID; }
        //    set { _processID = value; }
        //}

        //             this.recordFunction = printFunction;
        //public void Record(string logMsg)
        //{
        //    this.recordFunction(logMsg);
        //}
    }
}
