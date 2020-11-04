using System;
using System.ComponentModel.DataAnnotations;

namespace NackademinHotel.Model
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [Required] public DateTime StartBookDate { get; set; }
        [Required] public DateTime EndBookDate { get; set; }
        [Required] public virtual HotelRoom HotelRoom { get; set; }
        [Required] public virtual Customer Customer { get; set; }
        [Required] public virtual Invoice Invoice { get; set; }
        [Required] public bool Annulled { get; set; }

        internal bool IsBooked()
        {
            return StartBookDate > DateTime.Today && DateTime.Today < EndBookDate;
        }
    }
}