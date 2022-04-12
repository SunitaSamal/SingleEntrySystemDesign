using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SingleEntrySystemDesign.Models
{
    public class Transaction
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public TransactionType TransactionType { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public double TransactionAmount { get; set; }
    }

    public enum TransactionType
    {
        [Description("Dr")]
        Debit,
        [Description("Cr")]
        Credit
    } 
}
