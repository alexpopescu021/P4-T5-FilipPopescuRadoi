using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using BankingProject.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProjectTests.Controllers
{
    [TestClass]
    public class RequestsTests
    {
        [TestMethod]
        public void GetRequests()
        {
            Mock<IRequestRepository> mockRepository = new Mock<IRequestRepository>();

            Request expectedRequest1 = new Request
            {
                Id = Guid.Parse("34127349-B490-41EC-B173-99275DEF967A"),
                Type = "Loan",
                SendDate = DateTime.Now
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("34127349-B490-41EC-B173-99275DEF967A"))).Returns(expectedRequest1);
            Request expectedRequest2 = new Request
            {
                Id = Guid.Parse("EFD8A88F-EF17-4990-96D6-4E684A612EE6"),
                Type = "Card",
                SendDate = DateTime.Now
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("EFD8A88F-EF17-4990-96D6-4E684A612EE6"))).Returns(expectedRequest2);

            IEnumerable<Request> enumerable = Enumerable.Empty<Request>();
            IQueryable<Request> expectedRequests = enumerable.Prepend(expectedRequest1).Prepend(expectedRequest2).AsQueryable();
            mockRepository.Setup(x => x.GetAll()).Returns(expectedRequests);

            RequestsService requestsService = new RequestsService(mockRepository.Object);
            IEnumerable<Request> requests = requestsService.GetRequests();

            Assert.IsNotNull(requests);
            Assert.AreEqual(expectedRequests, requests);
        }
        [TestMethod]
        public void GetRequestsByUserId()
        {
            Mock<IRequestRepository> mockRepository = new Mock<IRequestRepository>();
            var newCustomer = new Customer()
            {
                Id = Guid.Parse("B5B44793-357D-4715-8BF9-5440DD713D64"),
                FirstName = "ala",
                LastName = "bala",
                UserId = Guid.Parse("D6D1A93B-FEF0-48B2-AE46-B8DBDD870441")
            };
            Request expectedRequest1 = new Request
            {
                Id = Guid.Parse("B81FCAD2-B932-4BCD-9987-CA711F7C987A"),
                Type = "Loan",
                SendDate = DateTime.Now,
                Customer = newCustomer
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("B81FCAD2-B932-4BCD-9987-CA711F7C987A"))).Returns(expectedRequest1);
            Request expectedRequest2 = new Request
            {
                Id = Guid.Parse("5967D0AB-8331-47FC-91AE-84F16A625843"),
                Type = "Card",
                SendDate = DateTime.Now,
                Customer = newCustomer
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("5967D0AB-8331-47FC-91AE-84F16A625843"))).Returns(expectedRequest2);

            IEnumerable<Request> enumerable = Enumerable.Empty<Request>();
            IQueryable<Request> expectedRequests = enumerable.Prepend(expectedRequest1).Prepend(expectedRequest2).AsQueryable();
            mockRepository.Setup(x => x.GetByCustomerId(Guid.Parse("B5B44793-357D-4715-8BF9-5440DD713D64"))).Returns(expectedRequests);

            RequestsService requestsService = new RequestsService(mockRepository.Object);
            IEnumerable<Request> requests = requestsService.GetRequestsByCustomerId("B5B44793-357D-4715-8BF9-5440DD713D64");

            Assert.IsNotNull(requests);
            Assert.AreEqual(expectedRequests, requests);
        }
        [TestMethod]
        public void GetRequestsById()
        {
            Mock<IRequestRepository> mockRepository = new Mock<IRequestRepository>();
            Request expectedRequest1 = new Request
            {
                Id = Guid.Parse("B81FCAD2-B932-4BCD-9987-CA711F7C987A"),
                Type = "Loan",
                SendDate = DateTime.Now
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("B81FCAD2-B932-4BCD-9987-CA711F7C987A"))).Returns(expectedRequest1);
            Request expectedRequest2 = new Request
            {
                Id = Guid.Parse("5967D0AB-8331-47FC-91AE-84F16A625843"),
                Type = "Card",
                SendDate = DateTime.Now
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("5967D0AB-8331-47FC-91AE-84F16A625843"))).Returns(expectedRequest2);

            RequestsService requestsService = new RequestsService(mockRepository.Object);
            Request request1 = requestsService.GetRequestById("B81FCAD2-B932-4BCD-9987-CA711F7C987A");
            Request request2 = requestsService.GetRequestById("5967D0AB-8331-47FC-91AE-84F16A625843");

            Assert.IsNotNull(request1);
            Assert.IsNotNull(request2);
            Assert.AreEqual(request1, expectedRequest1);
            Assert.AreEqual(request2, expectedRequest2);
        }
        [TestMethod]
        public void AddRequest()
        {
            Mock<IRequestRepository> mockRepository = new Mock<IRequestRepository>();
            Request expectedRequest1 = new Request
            {
                Id = Guid.Parse("B81FCAD2-B932-4BCD-9987-CA711F7C987A"),
                Type = "Loan",
                SendDate = DateTime.Now
            };
            mockRepository.Setup(x => x.Add(expectedRequest1)).Returns(expectedRequest1);
            Request expectedRequest2 = new Request
            {
                Id = Guid.Parse("5967D0AB-8331-47FC-91AE-84F16A625843"),
                Type = "Card",
                SendDate = DateTime.Now
            };
            mockRepository.Setup(x => x.Add(expectedRequest2)).Returns(expectedRequest2);

            RequestsService requestsService = new RequestsService(mockRepository.Object);
            Request request1 = requestsService.AddRequest(expectedRequest1);
            Request request2 = requestsService.AddRequest(expectedRequest2);

            Assert.IsNotNull(request1);
            Assert.IsNotNull(request2);
            Assert.AreEqual(request1, expectedRequest1);
            Assert.AreEqual(request2, expectedRequest2);
        }
    }
}
