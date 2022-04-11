using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SingleEntrySystemDesign.Models
{
    public class CashBook
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public UserProfile UserProfile { get; set; }
        [Required]
        public Transaction Transaction { get; set; }
        [Required]
        public double CashBalance { get; set; }
    }

    public class SingleLedgerEntry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public CashBook CashBook { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
