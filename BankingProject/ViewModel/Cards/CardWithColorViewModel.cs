using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ViewModel.Cards
{
    public class CardWithColorViewModel
    {
        public Card Card { get; set; }
        public CardMetaData CardColor { get; set; }
    }
}
