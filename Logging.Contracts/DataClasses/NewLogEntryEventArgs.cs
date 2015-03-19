using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.DataClasses
{
    public class NewLogEntryEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
