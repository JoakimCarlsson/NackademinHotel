using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace NackademinHotel.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; private set; }
        [Required]
        [StringLength(25)]
        public string LastName { get; private set; }
        [Required]
        [MaxLength(12)]
        public DateTime SocialSecurityNumber { get; private set; }
        public ICollection<Booking>? Bookings { get; private set; }
        
        public Customer(string firstName, string lastName, DateTime socialSecurityNumber)
        {
           ChangeFirstName(firstName);
           ChangeLastName(lastName);
           ChangeDateOfBirth(socialSecurityNumber);
        }

        internal void ChangeDateOfBirth(DateTime socialSecurityNumber)
        {
            if (socialSecurityNumber > DateTime.Now)
                throw new ArgumentException("Du kan inte vara född i framtiden.");

            SocialSecurityNumber = socialSecurityNumber;
        }

        internal void ChangeFirstName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Förnamnet kan inte vara tomt.");

            if (name.Length > 25)
                throw new ArgumentException("Förnamnet kan inte inte vara längre än 25 bokstäver.");

            FirstName = name;
        }
        
        internal void ChangeLastName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Efternamn kan inte vara tomt.");

            if (name.Length > 25)
                throw new ArgumentException("Efternamnet kan inte inte vara längre än 25 bokstäver.");

            LastName = name;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        
        public override string ToString()
        {
            return $"{GetFullName()}, Personnummer: {SocialSecurityNumber:yyyy-MM-dd}";
        }
    }
}