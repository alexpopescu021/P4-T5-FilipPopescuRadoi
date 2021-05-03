using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Model;
using BankingProject.ApplicationLogic.Abstractions;

namespace BankingProject.ApplicationLogic.Services
{
    public class CardServices
    {
        private readonly ICardRepository cardRepository;
        public CardServices(ICardRepository cardRepository)
        {
            this.cardRepository = cardRepository;
        }
        public Card GetCardByCardId(Guid CardId)
        {
            return cardRepository.GetById(CardId);
        }
    }
}
