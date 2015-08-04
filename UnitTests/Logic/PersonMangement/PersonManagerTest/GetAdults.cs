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
         public void GetAdults_RepoReturnOnChild_EmptyListReturned()
         {
             _repoMock.Setup(m => m.Query()).Returns(new List<Person> { new Person() { Age = 17 } }.AsQueryable());
             var expected = 0;

             var actual = _manager.GetAdults().Count();

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void GetAdults_RepoReturnTwoAdults_TwoAdultsReturned()
         {
             _repoMock.Setup(m => m.Query()).Returns(new List<Person>
             {
                 new Person() { Age = 18 },
                 new Person() { Age = 20 },
             }.AsQueryable());
             var expected = 2;

             var actual = _manager.GetAdults().Count();

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void GetAdults_RepoReturnOneAdultOneChild_OneAdultReturned()
         {
             _repoMock.Setup(m => m.Query()).Returns(new List<Person>
             {
                 new Person() { Age = 18 },
                 new Person() { Age = 17 },
             }.AsQueryable());
             var expected = 1;

             var actual = _manager.GetAdults().Count();

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void GetAdults_LoggerWasCalled()
         {
             _repoMock.Setup(m => m.Query()).Returns(new List<Person>().AsQueryable());

             _manager.GetAdults();

             _logMock.Verify(m => m.Log(It.IsAny<string>()));
         }
    }
}
