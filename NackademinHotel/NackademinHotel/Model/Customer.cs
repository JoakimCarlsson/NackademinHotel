using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NackademinHotel.Model
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(12)]
        public DateTime SocialSecurityNumber { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}