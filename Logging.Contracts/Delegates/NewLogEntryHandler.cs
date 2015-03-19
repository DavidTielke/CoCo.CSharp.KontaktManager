using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.DataClasses;

namespace DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.Delegates
{
    // Instead of a custom delegate, a usage of
    // the generic framework delegate EventHandler<T>
    // is the better choise, but this one is for
    // the demonstration of delegates inside a
    // component contract project
    public delegate void NewLogEntryHandler(object sender, NewLogEntryEventArgs args);
}
