using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SingleEntrySystemDesign.Models
{
    /// <summary>
    /// Bookkeeping holds Userprofile along with the daily transactions and remaining Cash Balance
    /// </summary>
    public class CashBook
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public UserProfile UserProfile { get; set; }
        [Required]
        public List<Transaction> Transactions { get; set; }
        [Required]
        public double CashBalance { get; set; }
    }

    /// <summary>
    /// Ledger Entry with CashBalance for a time period 
    /// </summary>
    public class SingleLedgerEntry
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public CashBook CashBook { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
