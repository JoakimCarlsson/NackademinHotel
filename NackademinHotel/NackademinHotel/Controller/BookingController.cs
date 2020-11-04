using System;
using System.Collections.Generic;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class BookingController
    {
        private HotelContext _hotelContext;
        public IEnumerable<Booking> GetAll()
        {
            using (_hotelContext = new HotelContext())
            {
                return _hotelContext.Bookings;
            }
        }

        public void SaveBooking(Customer customer, HotelRoom hotelRoom, DateTime startDate, DateTime endDate)
        {
            Booking booking = new Booking
            {
                Customer =  customer, 
                StartBookDate = startDate,
                EndBookDate =  endDate,
                HotelRoom = hotelRoom,
                Annulled =  false,
                
            };

            using (_hotelContext = new HotelContext())
            {
                _hotelContext.Bookings.Add(booking);
                _hotelContext.SaveChanges(); 
            }
        }

        private void RemoveBooking(Booking booking)
        {
            _hotelContext.Remove(booking);
            _hotelContext.SaveChanges();
        }
    }
}