﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ViewModel.Cards
{
    public enum NewPaymentStatus
    {
        NotInitiated = 0,
        Created,
        Failed
    }
    public class TransactionViewModel
    {
        [Required]
        [Display(Name = "Enter IBAN")]
        public string IBan { get; set; }
        [Required]
        [Display(Name = "Enter Amount")]
        public decimal Amount { get; set; }

        public Guid CardId { get; set; }
        [Required]
        [Display(Name = "Enter External Name")]
        public string ExternalName { get; set; }
        public NewPaymentStatus PaymentStatus { get; set; }
        public string PaymentMessage { get; set; }

    }
}
