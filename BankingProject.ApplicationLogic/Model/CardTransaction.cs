
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ApplicationLogic.Model
{
    public enum CardTransactionType
    {
        Online,
        Facility
    }
    public class CardTransaction : DataEntity
    {

        public virtual Transaction Transaction { get; set; }
        public CardTransactionType TransactionType { get; set; }

        public CardTransaction()
        {
        }

        public static CardTransaction Create(Transaction transaction, CardTransactionType transactionType)
        {
            return new CardTransaction
            {
                Id = Guid.NewGuid(),
                Transaction = transaction,
                TransactionType = transactionType

            };
        }
    }
}
