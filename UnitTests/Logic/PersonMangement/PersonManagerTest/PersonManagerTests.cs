using System;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts;
using DotNetPro.KontaktManager.Data.Repositories.Contracts;
using DotNetPro.KontaktManager.Logic.PersonManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.Logic.PersonMangement.PersonManagerTest
{
    [TestClass]
    public partial class PersonManagerTests
    {
        private PersonManager _manager;
        private Mock<IPersonRepository> _repoMock;
        private Mock<ILogger> _logMock;
        
        [TestInitialize]
        public void TestInitialize()
        {
            _repoMock = new Mock<IPersonRepository>();
            _logMock = new Mock<ILogger>();
            _manager = new PersonManager(_repoMock.Object, _logMock.Object);
        }
    }
}
