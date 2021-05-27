using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using BankingProject.ApplicationLogic.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BankingProjectTests.Controllers
{
    [TestClass]
    public class CardsTests
    {
        public readonly IBaseRepository<Card> MockCardRepository;

        public CardsTests()
        {
            IList<Card> expectedCards = new List<Card>
            {
                new Card { Id = Guid.Parse("4CE11219-5BCC-40DA-843B-F6902D1D64E6"), SerialNumber = "12345678", CVV = 123, CreateDate = DateTime.Now },
                new Card { Id = Guid.NewGuid(), SerialNumber = "28313329", CVV = 672, CreateDate = DateTime.Now }
            };

            Mock<IBaseRepository<Card>> mockCardRepository = new Mock<IBaseRepository<Card>>();
            mockCardRepository.Setup(c => c.GetAll()).Returns(expectedCards);

            mockCardRepository.Setup(c => c.GetById(
               It.IsAny<Guid>())).Returns((Guid i) => expectedCards.Where(
               x => x.Id == i).Single());

            this.MockCardRepository = mockCardRepository.Object;
        }


        public TestContext TestContext { get; set; }

        [TestMethod]
        public void AddCard()
        {
            Card card1 = this.MockCardRepository.GetById(Guid.Parse("4CE11219-5BCC-40DA-843B-F6902D1D64E6"));
            this.MockCardRepository.Add(card1);

            Assert.IsNotNull(card1);
            Assert.AreEqual(card1, this.MockCardRepository.GetById(Guid.Parse("4CE11219-5BCC-40DA-843B-F6902D1D64E6")));
        }

        [TestMethod]
        public void GetCardByCardId()
        {
            Mock<ICardRepository> mockRepository = new Mock<ICardRepository>();

            Card expectedCard1 = new Card
            {
                Id = Guid.Parse("6E7CADF6-8E4E-4259-85A7-445EED150AAE"),
                SerialNumber = "12345678",
                CVV = 123,
                CreateDate = DateTime.Now,
                //ExpDare
                //OwnerName
                //BankAccount
                //CardTransactions
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("6E7CADF6-8E4E-4259-85A7-445EED150AAE"))).Returns(expectedCard1);

            Card expectedCard2 = new Card
            {
                Id = Guid.Parse("06106F9D-B68B-437B-B1D0-398FC196FE96"),
                SerialNumber = "45830283",
                CVV = 575,
                CreateDate = DateTime.Now
            };
            mockRepository.Setup(x => x.GetById(Guid.Parse("06106F9D-B68B-437B-B1D0-398FC196FE96"))).Returns(expectedCard2);

            CardServices cardService = new CardServices(mockRepository.Object);
            Card card1 = cardService.GetCardByCardId(Guid.Parse("6E7CADF6-8E4E-4259-85A7-445EED150AAE"));
            Card card2 = cardService.GetCardByCardId(Guid.Parse("06106F9D-B68B-437B-B1D0-398FC196FE96"));


            Assert.IsNotNull(card1);
            Assert.IsNotNull(card2);

            Assert.AreEqual(card1, expectedCard1);
            Assert.AreEqual(card2, expectedCard2);
        }

        [TestMethod]
        public void GetAllCardTransactions()
        {
            Mock<ICardRepository> mockRepository = new Mock<ICardRepository>();

           

            var transaction = new Transaction()
            {
                Id = Guid.Parse("EFD8A88F-EF17-4990-96D6-4E684A612EE6"),
                ExternalIBAN = "2817312313",
                ExternalName = "Test",
                Amount = 100,
                Time = DateTime.Now,
                Details = "test test",
                Status = TransactionStatus.Accepted,
                BankAccountId = Guid.NewGuid()
            };

            var cardTransaction = CardTransaction.Create(transaction, CardTransactionType.Online);
            ICollection<CardTransaction> cardTransactions = new Collection<CardTransaction>();
            cardTransactions.Add(cardTransaction);

            Card expectedCard1 = new Card
            {
                Id = Guid.Parse("22378E12-AAE4-4F28-AFBB-9D83A8B24A43"),
                SerialNumber = "12345678",
                CVV = 123,
                CreateDate = DateTime.Now,
                CardTransactions = cardTransactions
            };


            //cardTransaction = CardTransaction.Create(transaction, transactionType);
            expectedCard1.CardTransactions.Append(cardTransaction);
            //expectedCard1.CardTransactions.Add(cardTransaction);


            mockRepository.Setup(x => x.GetById(Guid.Parse("22378E12-AAE4-4F28-AFBB-9D83A8B24A43"))).Returns(expectedCard1);
            
            IEnumerable<CardTransaction> enumerable = Enumerable.Empty<CardTransaction>();
            IQueryable<CardTransaction> expectedTransactions = enumerable.Prepend(cardTransaction).AsQueryable();
            //mockRepository.Setup(x => x.GetById(Guid.Parse("22378E12-AAE4-4F28-AFBB-9D83A8B24A43"))).Returns(expectedTransactions);

            CardServices cardService = new CardServices(mockRepository.Object);
            IEnumerable<CardTransaction> transactions = cardService.GetAllCardTransactions(Guid.Parse("22378E12-AAE4-4F28-AFBB-9D83A8B24A43"));

            Assert.IsNotNull(transactions);
            Assert.AreEqual(expectedCard1.CardTransactions, transactions);
        }

        [TestMethod]
        public void CanUpdateCard()
        {
            // Find a product by id
            Card testCard = this.MockCardRepository.GetById(Guid.Parse("4CE11219-5BCC-40DA-843B-F6902D1D64E6"));

            // Change one of its properties
            testCard.CVV = 111;
            

            // Save our changes.
            this.MockCardRepository.Update(testCard);

            // Verify the change
            Assert.AreEqual(111, this.MockCardRepository.GetById(Guid.Parse("4CE11219-5BCC-40DA-843B-F6902D1D64E6")).CVV);
        }
    }
}
