using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPro.KontaktManager.CrossCutting.Logging.Contracts.Exceptions
{
    [Serializable]
    public class LoggingConfigurationException : LoggingException
    {
        public LoggingConfigurationException()
        {
        }

        public LoggingConfigurationException(string message) : base(message)
        {
        }

        public LoggingConfigurationException(string message, Exception inner) : base(message, inner)
        {
        }

        protected LoggingConfigurationException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
