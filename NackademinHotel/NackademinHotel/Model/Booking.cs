using System;
using System.ComponentModel.DataAnnotations;

namespace NackademinHotel.Model
{
    public class Booking
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartBookDate { get; set; }
        [Required]
        public DateTime EndBookDate { get; set; }
        [Required]
        public HotelRoom HotelRoom { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Invoice Invoice { get; set; }
        [Required]
        public bool Annulled { get; set; }
    }
}
