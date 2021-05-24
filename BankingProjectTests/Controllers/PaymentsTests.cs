using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using BankingProject.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoqRepositorySample;
namespace BankingProjectTests.Controllers
{
    [TestClass]
    public class PaymentsTests
    {

       
        public PaymentsTests() {

            IList<Transaction> transactions = new List<Transaction>
                {
                    new Transaction { Id = Guid.Parse("32CDB050-7458-44A9-BC49-B61C06A868F2"),Amount= 100,BankAccountId = Guid.NewGuid() },
                    new Transaction { Id = Guid.NewGuid(),Amount= 200,BankAccountId = Guid.NewGuid() },
                    new Transaction { Id = Guid.NewGuid(),Amount= 300,BankAccountId = Guid.NewGuid() }
                };

            Customer customer = new Customer { Id = Guid.NewGuid(),UserId = Guid.Parse("717f05c0-d3dc-4628-8ee8-77058db72e2e") };
            
            Mock<IBaseRepository<Transaction>> mockTransactionRepository = new Mock<IBaseRepository<Transaction>>();

            mockTransactionRepository.Setup(mr => mr.GetAll()).Returns(transactions);

            mockTransactionRepository.Setup(mr => mr.GetById(
               It.IsAny<Guid>())).Returns((Guid i) => transactions.Where(
               x => x.Id == i).Single());

           

            this.MockTransactionsRepository = mockTransactionRepository.Object;
        }
        public readonly IBaseRepository<Transaction> MockTransactionsRepository;
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void CanReturnAllTransactions()
        {
            // Try finding all products
            ICollection<Transaction> testTransactions = (ICollection<Transaction>)this.MockTransactionsRepository.GetAll();

            Assert.IsNotNull(testTransactions); // Test if null
            Assert.AreEqual(3, testTransactions.Count()); // Verify the correct Number
        }

        [TestMethod]
        public void CanReturnTransactionById()
        {
            // Try finding a product by id
            Transaction testTransaction = this.MockTransactionsRepository.GetById(Guid.Parse("32CDB050-7458-44A9-BC49-B61C06A868F2"));

            Assert.IsNotNull(testTransaction); // Test if null
            Assert.IsInstanceOfType(testTransaction, typeof(Transaction)); // Test type
            Assert.AreEqual(100, testTransaction.Amount); // Verify it is the right product
        }

        [TestMethod]
        public void CanUpdateTransaction()
        {
            // Find a product by id
            Transaction testTransaction = this.MockTransactionsRepository.GetById(Guid.Parse("32CDB050-7458-44A9-BC49-B61C06A868F2"));

            // Change one of its properties
            testTransaction.Amount = 111;

            // Save our changes.
            this.MockTransactionsRepository.Update(testTransaction);

            // Verify the change
            Assert.AreEqual(111, this.MockTransactionsRepository.GetById(Guid.Parse("32CDB050-7458-44A9-BC49-B61C06A868F2")).Amount);
        }
    }
}
