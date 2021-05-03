
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ApplicationLogic.Model
{
    public enum TransactionStatus
    {
        Created,
        Processing,
        Accepted,
        Rejected
    }
    public class Transaction : DataEntity
    {
        public string ExternalIBAN { get; set; }
        public string ExternalName { get; set; }
        public decimal Amount { get; set; }
        public DateTime Time { get; set; }
        public string Details { get; set; }
        public TransactionStatus Status { get; set; }
        public Guid BankAccountId { get; set; }



        public Transaction()
        {
        }

        public static Transaction Create(decimal amount, Guid bankAccountId, string externalName, string externalIBAN, string details)
        {
            //validare iban - throw exception
            return new Transaction
            {
                Id = Guid.NewGuid(),
                BankAccountId = bankAccountId,
                ExternalIBAN = externalIBAN,
                ExternalName = externalName,
                Amount = amount,
                Time = DateTime.UtcNow,
                Details = details,
                Status = TransactionStatus.Created
            };
        }
    }
}
