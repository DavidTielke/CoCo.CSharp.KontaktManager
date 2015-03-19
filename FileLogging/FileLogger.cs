using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.DataClasses;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.Delegates;

namespace DotNetPro.KontaktManager.CrossCutting.FileLogging
{
    public class FileLogger : ILogger
    {
        public event NewLogEntryHandler NewLogEntry;
        public void Log(string message)
        {
            File.WriteAllText("log.txt", message);
        }

        public void Configure(LoggingConfiguration configuration)
        {

        }
    }
}
