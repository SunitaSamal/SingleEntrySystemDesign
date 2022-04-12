using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SingleEntrySystemDesign.Models
{
    public class UserProfile
    {
        [Key]
        public string Id { get; set; }
        [DisplayName("First Name is required")]
        [Required]
        [MaxLength(75)]
        public string FirstName { get; set; }

        [DisplayName("Last Name is required")]
        [Required]
        [MaxLength(75)]
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        [Required]
        public List<Address> AddressList { get; set; }
    }

    public class Address 
    {
        [Key]
        public string Id { get; set; }
        public AddressType AddressType { get; set; }

        [DisplayName("Address is required")]
        [Required]
        [MaxLength(200)]
        public string AddressLine1 { get; set; }

        [MaxLength(200)]
        public string AddressLine2 { get; set; }

        [DisplayName("City is required")]
        [Required]
        public string City { get; set; }

        [DisplayName("State is required")]
        [Required]
        public string State { get; set; }

        [DisplayName("Country is required")]
        [Required]
        public string Country { get; set; }

        [DisplayName("ZipCode is required")]
        [Required]
        public int ZipCode { get; set; }
    }

    public enum AddressType
    { 
        Primary,` 
        Secondary
    }
}
