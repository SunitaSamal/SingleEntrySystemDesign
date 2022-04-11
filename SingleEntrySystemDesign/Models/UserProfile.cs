using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SingleEntrySystemDesign.Models
{ 
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(75)]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        [Required]
        public AddressType PrimaryAddress { get; set; }
    }

    public class AddressType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string AddressLine1 { get; set; }

        [MaxLength(200)]
        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public int ZipCode { get; set; }
    }
}
