using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIMappings.CrossCutting;
using DIMappings.Data;
using DIMappings.Logic;
using Ninject.Modules;

namespace DIMappings
{
    public static class Aggregator
    {
        public static INinjectModule[] Mappings
        {
            get
            {
                return new INinjectModule[]
                {
                    new LoggingMappings(), 
                    new PersonManagementMappings(), 
                    new RepositoryMappings(), 
                };
            }
        }
    }
}
