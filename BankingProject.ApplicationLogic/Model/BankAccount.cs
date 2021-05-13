using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ApplicationLogic.Model
{
    public class BankAccount : DataEntity
    {
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        private List<Transaction> transactions = new List<Transaction>();
        public virtual IReadOnlyCollection<Transaction> Transactions
        {
            get
            {
                return transactions.AsReadOnly();
            }
            private set
            {
                transactions = new List<Transaction>(value);
            }
        }

        private static bool IsValidIBAN(string IBAN)
        {
            if (IBAN.Length == 24)
                return true;


            return false;
        }

        public static BankAccount Create(string accountIBAN)
        {

            if (!IsValidIBAN(accountIBAN))
                throw new Exception(accountIBAN);

            return new BankAccount
            {
                Id = Guid.NewGuid(),
                Balance = new decimal(0.0),
                IBAN = accountIBAN
            };
        }

        private void AddTransaction(Transaction transaction)
        {
            Transactions.Count();
            transactions.Add(transaction);
            LastTransactionDate = DateTime.UtcNow;
        }

        public Transaction CreatePayment(decimal amount, string destinationName, string destinationIBAN, string description)
        {
            if (amount <= 0)
                throw new Exception("");

            if (string.IsNullOrEmpty(destinationName))
                throw new Exception("");

            if (amount > Balance)
            {
                //throw new NotEnoughFundsException(Balance, amount);
            }

            Transactions.Count();
            var transaction = Transaction.Create(-amount, Id, destinationName, destinationIBAN, description);

            AddTransaction(transaction);

            Balance -= amount;

            return transaction;
        }

        public Transaction CreateReceive(decimal amount, string sourceName, string sourceIBAN, string description)
        {
            if (string.IsNullOrEmpty(sourceName) && string.IsNullOrEmpty(sourceIBAN))
                throw new Exception("");

            if (amount <= 0)
                throw new Exception("");

            Transactions.Count();
            var transaction = Transaction.Create(amount, Id, sourceName, sourceIBAN, description);
            AddTransaction(transaction);

            Balance += amount;

            return transaction;
        }

        public decimal GetAmountPaidInCurrentMonth()
        {
            var paidThisMonth = Transactions.Where(transaction =>
                                                            transaction.Time.Year == DateTime.UtcNow.Year &&
                                                            transaction.Time.Month == DateTime.UtcNow.Month &&
                                                            transaction.Amount < 0
                                                            )
                                                    .Sum(transaction => transaction.Amount);
            return paidThisMonth;

        }
    }
}
