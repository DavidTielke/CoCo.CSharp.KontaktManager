using System.Collections.Generic;
using DotNetPro.KontaktManager.CrossCutting.DataClasses;

namespace DotNetPro.KontaktManager.Logik.PersonManagement.Contracts
{
    public interface IPersonManager
    {
        IEnumerable<Person> GetAll();
        IEnumerable<Person> GetAdults();
        IEnumerable<Person> GetChildren();
    }
}