using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.DataClasses;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.Delegates;

namespace DotNetPro.KontaktManager.CrossCutting.Logging.Contracts
{
    public interface ILogger
    {
        event NewLogEntryHandler NewLogEntry;
        void Log(string message);
        void Configure(LoggingConfiguration configuration);
    }
}
