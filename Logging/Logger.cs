using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.DataClasses;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.Delegates;

namespace DotNetPro.KontaktManager.CrossCutting.Logging
{
    public class Logger : ILogger
    {
        public event NewLogEntryHandler NewLogEntry;
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Configure(LoggingConfiguration configuration)
        {
        }
    }
}
