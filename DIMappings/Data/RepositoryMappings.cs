using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.Data.Repositories;
using DotNetPro.KontaktManager.Data.Repositories.Contracts;
using Ninject.Modules;

namespace DIMappings.Data
{
    class RepositoryMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonRepository>().To<PersonRepository>();
        }
    }
}
