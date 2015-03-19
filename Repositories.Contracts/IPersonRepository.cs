using System.Linq;
using DotNetPro.KontaktManager.CrossCutting.DataClasses;

namespace DotNetPro.KontaktManager.Data.Repositories.Contracts
{
    public interface IPersonRepository
    {
        IQueryable<Person> Query();
    }
}