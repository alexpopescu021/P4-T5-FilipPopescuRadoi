using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ApplicationLogic.Services
{
    public class LoanService
    {
        private readonly ILoanRepository loanRepository;

        public LoanService(ILoanRepository loanRepository)
        {
            this.loanRepository = loanRepository;
        }

        public IEnumerable<Loan> GetLoans()
        {
            return loanRepository.GetAll();
        }
        public void AddLoan(Loan loan)
        {
            loanRepository.Add(loan);
        }
    }
}
