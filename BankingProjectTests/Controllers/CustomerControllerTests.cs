using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using BankingProject.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace BankingProjectTests.Controllers
{
    [TestClass]
    public class CustomerControllerTests
    {
        [TestMethod]
        public void GetCustomers()
        {
            Mock<ICustomerRepository> mockCustomerRepo = new Mock<ICustomerRepository>();
            var customer1 = new Customer()
            {
                Id = Guid.Parse("B5B44793-357D-4715-8BF9-5440DD713D64"),
                FirstName = "ala",
                LastName = "bala",
                UserId = Guid.Parse("D6D1A93B-FEF0-48B2-AE46-B8DBDD870441")
            };
            var customer2 = new Customer()
            {
                Id = Guid.Parse("32CDB050-7458-44A9-BC49-B61C06A868F2"),
                FirstName = "ala",
                LastName = "bala",
                UserId = Guid.Parse("D435A9A7-ADC0-489A-9B02-E17A7EEC32BB")
            };
            var customer3 = new Customer()
            {
                Id = Guid.Parse("6A47E913-159C-4EC9-93B3-C316B6CB64AC"),
                FirstName = "ala",
                LastName = "bala",
                UserId = Guid.Parse("58BE7C07-9728-4B46-BCEA-0305C0A63CD6")
            };
            IEnumerable<Customer> enumerable = Enumerable.Empty<Customer>();
            IQueryable<Customer> expectedCustomers = enumerable.Prepend(customer1).Prepend(customer2).Prepend(customer3).AsQueryable();
            mockCustomerRepo.Setup(x => x.GetCustomers()).Returns(expectedCustomers);


            CustomerService customerService = new CustomerService(mockCustomerRepo.Object);
            IEnumerable<Customer> customers = customerService.GetCustomers();

            Assert.IsNotNull(customers);
            Assert.AreEqual(expectedCustomers, customers);
        }

        [TestMethod]
        public void FindByLastNameTest()
        {
            Mock<ICustomerRepository> mockCustomerRepo = new Mock<ICustomerRepository>();
           
            var details = new ContactDetails
            {
                Id = Guid.NewGuid(),
                Address = "test",
                AlternatePhoneNo = "test",
                City = "test",
                Country = "test",
                Email = "test",
                PhoneNo = "test"
            };
            var customer1 = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "ala",
                LastName = "bala",
                UserId = Guid.NewGuid(),
                ContactDetails = details
            };

            var customer2 = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "asadsasd",
                LastName = "bala",
                UserId = Guid.NewGuid()
            };

            IEnumerable<Customer> enumerable = Enumerable.Empty<Customer>();
            IQueryable<Customer> expectedCustomers = enumerable.Prepend(customer1).Prepend(customer2).AsQueryable();
            mockCustomerRepo.Setup(x => x.FindByLastName(customer1.LastName)).Returns(expectedCustomers);

            CustomerService customerService = new CustomerService(mockCustomerRepo.Object);
            var customersWithTheSameName = customerService.FindByLastName(customer1.LastName);

            Assert.IsNotNull(customersWithTheSameName);
            Assert.IsNotNull(expectedCustomers);
            Assert.AreEqual(customersWithTheSameName, expectedCustomers);
            //File.WriteAllText(@"C:\AdHocConsole\" + "test" + ".txt", customer1.ContactDetails.Address.ToString());

            //Assert.AreEqual(customer1.ContactDetails, expectedCustomer.ContactDetails);
        }

        [TestMethod]
        public void UpdateCustomer()
        {
            Mock<ICustomerRepository> mockCustomerRepository = new Mock<ICustomerRepository>();

            Customer expectedCustomer1 = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Doe",
                UserId = Guid.NewGuid()
            };
            mockCustomerRepository.Setup(x => x.Add(expectedCustomer1)).Returns(expectedCustomer1);

            CustomerService customerService = new CustomerService(mockCustomerRepository.Object);
            expectedCustomer1.FirstName = "Test";
            customerService.UpdateCustomer(expectedCustomer1);

            Assert.IsNotNull(expectedCustomer1);
            Assert.AreEqual("Test", expectedCustomer1.FirstName);
        }
        

        [TestMethod]
        public void GetCustomerFromUserId()
        {
            Mock<ICustomerRepository> mockCustomerRepository = new Mock<ICustomerRepository>();

            //_userManager.Setup(x => x.CreateAsync(user,"TestPassword")).ReturnsAsync(IdentityResult.Success); ;

            Customer expectedCustomer1 = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Doe",
                UserId = Guid.Parse("717f05c0-d3dc-4628-8ee8-77058db72e2e")
            };
            mockCustomerRepository.Setup(x => x.GetCustomerByUserId(expectedCustomer1.UserId)).Returns(expectedCustomer1);

            CustomerService customerService = new CustomerService(mockCustomerRepository.Object);
            var customer1 = customerService.GetCustomerFromUserId("717f05c0-d3dc-4628-8ee8-77058db72e2e");

            Assert.IsNotNull(customer1);
            Assert.AreEqual(customer1.Id, expectedCustomer1.Id);

        }
    }
}
