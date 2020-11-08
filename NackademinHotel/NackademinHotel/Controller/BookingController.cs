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
        private HotelContext _dbContext;
        private InvoiceController _invoiceController = new InvoiceController();
        public IEnumerable<Booking> GetAll()
        {
            using (_dbContext = new HotelContext())
            {
                return _dbContext.Bookings.Include(b => b.Customer).
                    Include(b => b.Invoice).
                    Include(b => b.HotelRoom).
                    Include(b => b.Customer).ToList();
            }
        }

        public IEnumerable<Booking> GetAllActive()
        {
            using (_dbContext = new HotelContext())
            {
                return _dbContext.Bookings.Include(b => b.Customer).
                    Include(b => b.Invoice).
                    Include(b => b.HotelRoom).
                    Include(b => b.Customer)
                    .Where(b => !b.Annulled).ToList();
            }
        }

        public bool SaveBooking(Customer customer, HotelRoom hotelRoom,int extraBeds, DateTime startDate, DateTime endDate, bool payed)
        {
            using (_dbContext = new HotelContext())
            {
                Booking booking = new Booking
                {
                    Customer = _dbContext.Customers.FirstOrDefault(c => c.Id == customer.Id),
                    StartBookDate = startDate,
                    EndBookDate = endDate,
                    HotelRoom = _dbContext.HotelRooms.Include(h => h.Hotel).FirstOrDefault(h => h.Id == hotelRoom.Id),
                    Annulled = false,
                    ExtraBeds = extraBeds,
                    Invoice = _invoiceController.CreateInvoice(DateTime.Today, payed),
                };

                _dbContext.Bookings.Add(booking);
                _dbContext.SaveChanges();

                return true;
            }
        }

        private void RemoveBooking(Booking booking)
        {
            _dbContext.Remove(booking);
            _dbContext.Remove(booking.Invoice);
            _dbContext.SaveChanges();
        }

        public bool UpdateBooking(Booking booking, DateTime startDate, DateTime endDate, bool paid, int extraBeds)
        {
            booking.SetDates(startDate, endDate);
            booking.Invoice.IsPayed(paid);
            booking.ExtraBeds = extraBeds;
            
            using (_dbContext = new HotelContext())
            {
                _dbContext.Update(booking);
                _dbContext.SaveChanges();
                return true;
            }
        }

        public bool CancelBooking(Booking booking)
        {
            using (_dbContext = new HotelContext())
            {
                booking.Annulled = true;
                _dbContext.Update(booking);
                _dbContext.SaveChanges();
                return true;
            }
        }
    }
}