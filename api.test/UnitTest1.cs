using BankingProject.ApplicationLogic.Services;
using BankingProject.Controllers;
using Moq;
using NUnit.Framework;

namespace api.test
{
    public class Tests
    {
        private AccountsController controller;
        [SetUp]
        public void Setup()
        {
            var accountServiceMock = new Mock<AccountsService>();
            
        }

        [Test]
        public void Test1()
        {
           
            accountServiceMock.
            Assert.Pass();
        }
    }
}