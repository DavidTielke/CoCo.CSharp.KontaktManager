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
        public void GetChildren_RepoReturnOnAdult_EmptyListReturned()
        {
            _repoMock.Setup(m => m.Query()).Returns(new List<Person> { new Person() { Age = 18 } }.AsQueryable());
            var expected = 0;

            var actual = _manager.GetChildren().Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetChildren_RepoReturnTwoChilds_TwoChildsReturned()
        {
            _repoMock.Setup(m => m.Query()).Returns(new List<Person>
             {
                 new Person() { Age = 17 },
                 new Person() { Age = 5 },
             }.AsQueryable());
            var expected = 2;

            var actual = _manager.GetChildren().Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetChildren_RepoReturnOneAdultOneChild_OneChildReturned()
        {
            _repoMock.Setup(m => m.Query()).Returns(new List<Person>
             {
                 new Person() { Age = 18 },
                 new Person() { Age = 17 },
             }.AsQueryable());
            var expected = 1;

            var actual = _manager.GetChildren().Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetChildren_LoggerWasCalled()
        {
            _repoMock.Setup(m => m.Query()).Returns(new List<Person>().AsQueryable());

            _manager.GetChildren();

            _logMock.Verify(m => m.Log(It.IsAny<string>()));
        }
    }
}
