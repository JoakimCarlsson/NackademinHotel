using System;
using System.ComponentModel.DataAnnotations;

namespace NackademinHotel.Model
{
    public class Booking
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime StartBookDate { get; set; }
        [Required] public DateTime EndBookDate { get; set; }
        [Required] public HotelRoom HotelRoom { get; set; }
        [Required] public Customer Customer { get; set; }
        [Required] public Invoice Invoice { get; set; }
        [Required] public bool Annulled { get; set; }
        public int? ExtraBeds { get; set; }


        public Booking()
        {
            
        }

        internal bool IsBooked()
        {
            return DateTime.Now >= StartBookDate && DateTime.Now < EndBookDate;
        }

        public override string ToString()
        {
            return $"Aktiv bokningar";
        }

        public void SetDates(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new ArgumentException("Slut datum kan inte vara före start datum");
            }
            else
            {
                StartBookDate = startDate;
                EndBookDate = endDate;
            }
        }
    }
}