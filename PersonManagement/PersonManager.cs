using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.DataClasses;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts;
using DotNetPro.KontaktManager.Data.Repositories.Contracts;
using DotNetPro.KontaktManager.Logik.PersonManagement.Contracts;

namespace DotNetPro.KontaktManager.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _repository;
        private readonly ILogger _logger;

        public PersonManager(IPersonRepository repository,
            ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Person> GetAll()
        {
            _logger.Log("Alle Personen laden");
            return _repository.Query()
                .AsEnumerable();
        }

        public IEnumerable<Person> GetAdults()
        {
            return _repository.Query()
                .Where(p => p.Age >= 18);
        }

        public IEnumerable<Person> GetChildren()
        {
            return _repository.Query()
                .Where(p => p.Age < 18);
        }
    }
}
