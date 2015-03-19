using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.FileLogging;
using DotNetPro.KontaktManager.CrossCutting.Logging;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts;
using Ninject.Modules;

namespace DIMappings.CrossCutting
{
    class LoggingMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<FileLogger>();
        }
    }
}
