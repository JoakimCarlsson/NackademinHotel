using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class BookingController
    {
        private HotelContext dbContext;
        public IEnumerable<Booking> GetAll()
        {
            using (dbContext = new HotelContext())
            {
                var test = dbContext.Bookings.Include(b => b.Customer).Include(b => b.Invoice).ToList();
                return test;
            }
        }

        public bool SaveBooking(Customer customer, HotelRoom hotelRoom, DateTime startDate, DateTime endDate)
        {
            using (dbContext = new HotelContext())
            {
                Booking booking = new Booking
                {
                    Customer = dbContext.Customers.FirstOrDefault(c => c.Id == customer.Id),
                    StartBookDate = startDate,
                    EndBookDate = endDate,
                    HotelRoom = dbContext.HotelRooms.Include(h => h.Hotel).FirstOrDefault(h => h.Id == hotelRoom.Id),
                    Annulled = false,
                    Invoice = new Invoice
                    {
                        BookedDate = startDate,
                        Payed = true,
                    }
                };

                dbContext.Bookings.Add(booking);
                dbContext.SaveChanges();

                return true;
            }
        }

        private void RemoveBooking(Booking booking)
        {
            dbContext.Remove(booking);
            dbContext.SaveChanges();
        }
    }
}