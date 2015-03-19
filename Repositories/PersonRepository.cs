using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.DataClasses;
using DotNetPro.KontaktManager.Data.Repositories.Contracts;

namespace DotNetPro.KontaktManager.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<Person> Query()
        {
            return new List<Person>
            {
                new Person {Firstname = "David", Lastname = "Tielke", Age = 30},
                new Person {Firstname = "Maximilian", Lastname = "Tielke", Age = 2},
            }.AsQueryable();
        }
    }
}
