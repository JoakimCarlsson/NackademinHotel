using System;
using System.ComponentModel.DataAnnotations;

namespace NackademinHotel.Model
{
    public class Booking
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime StartBookDate { get; private set; }
        [Required] public DateTime EndBookDate { get; private set; }
        [Required] public HotelRoom HotelRoom { get; private set; }
        [Required] public Customer Customer { get; private set; }
        [Required] public Invoice Invoice { get; private set; }
        [Required] public bool Annulled { get; set; }
        public int? ExtraBeds { get; set; }


        public Booking()
        {
            
        }

        public Booking(DateTime startBookDate, DateTime endBookDate, HotelRoom hotelRoom, Customer customer, int extraBeds)
        {
            SetDates(startBookDate, endBookDate);
            HotelRoom = hotelRoom;
            Customer = customer;
            ExtraBeds = extraBeds;
        }

        public void SetInvoice(Invoice invoice)
        {
            Invoice = invoice;
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