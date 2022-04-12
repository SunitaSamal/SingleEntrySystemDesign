using SingleEntrySystemDesign.Models;
using System;

namespace SingleEntrySystemDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLedgerEntry singleLedgerEntry = new SingleLedgerEntry()
            {
                Id = System.Guid.NewGuid().ToString(),
                StartDate = new DateTime(2022, 4, 4),
                EndDate = DateTime.Now,
                CashBook = new CashBook()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    CashBalance = 10000,
                    Transactions = new System.Collections.Generic.List<Transaction>() {
                         new Transaction() {
                             Id = System.Guid.NewGuid().ToString(),
                             TransactionAmount = 2000,
                             TransactionDate = new DateTime(2022,4, 6),
                             TransactionType = TransactionType.Debit},
                         new Transaction() {
                             Id = System.Guid.NewGuid().ToString(),
                             TransactionAmount = 3000,
                             TransactionDate = new DateTime(2022,4, 7),
                             TransactionType = TransactionType.Credit}
                     },
                    UserProfile = new UserProfile()
                    {
                        Id = System.Guid.NewGuid().ToString(),
                        FirstName = "John",
                        LastName = "Wright",
                        EmailAddress = "John.Wright1234567@gmail.com",
                        PhoneNumber = "011-87878788787",
                        AddressList = new System.Collections.Generic.List<Address>
                        {
                           new Address() 
                           { 
                               Id = System.Guid.NewGuid().ToString(), AddressType = AddressType.Primary, AddressLine1 = "TEST 123",
                               City= "Bangalore", State = "Karnataka", Country = "India", ZipCode = 560040
                           }
                      }
                    }
                }
            };
            Console.WriteLine("Hello World!");
        }
    }
}
