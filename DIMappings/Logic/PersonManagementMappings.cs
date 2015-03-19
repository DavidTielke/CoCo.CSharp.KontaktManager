using DotNetPro.KontaktManager.Logic.PersonManagement;
using DotNetPro.KontaktManager.Logik.PersonManagement.Contracts;
using Ninject.Modules;

namespace DIMappings.Logic
{
    class PersonManagementMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonManager>().To<PersonManager>();
        }
    }
}
