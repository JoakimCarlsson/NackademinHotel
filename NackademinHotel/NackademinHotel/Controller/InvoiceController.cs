using System;
using System.Collections.Generic;
using System.Linq;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class InvoiceController
    {
        private HotelContext _hotelContext;

        internal IEnumerable<Invoice> GetAll()
        {
            using (_hotelContext = new HotelContext())
            {
                return _hotelContext.Invoices.ToList();
            }
        }

        internal Invoice CreateInvoice(DateTime bookedDate, bool payed)
        {
            return new Invoice(bookedDate, payed);
        }
    }
}