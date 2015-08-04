using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.KontaktManager.CrossCutting.DataClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.Logic.PersonMangement.PersonManagerTest
{
    public partial class PersonManagerTests
    {
        [TestMethod]
        public void GetAll_RepoIsEmpty_EmptyListReturned()
        {
            _repoMock.Setup(m => m.Query()).Returns(new List<Person>().AsQueryable());
            var expected = 0;

            var actual = _manager.GetAll().Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAll_RepoReturnTwo_ListWithTwoItems()
        {
            _repoMock.Setup(m => m.Query()).Returns(new List<Person>
            {
                new Person(), new Person()
            }.AsQueryable());
            var expected = 2;

            var actual = _manager.GetAll().Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAll_LoggerWasCalled()
        {
            _repoMock.Setup(m => m.Query()).Returns(new List<Person>().AsQueryable());

            _manager.GetAll();

            _logMock.Verify(m => m.Log(It.IsAny<string>()));
        }
    }
}
