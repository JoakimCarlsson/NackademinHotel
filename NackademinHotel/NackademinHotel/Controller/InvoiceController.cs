using System;
using System.Collections.Generic;
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
                return _hotelContext.Invoices;
            }
        }

        internal Invoice CreateInvoice(DateTime bookedDate, bool payed)
        {
            return new Invoice(bookedDate, payed);
        }

        internal bool IsPaidWithinDays(Invoice invoice, int days)
        {
            if (!invoice.Payed)
            {
                if ((invoice.BookedDate - DateTime.Now).TotalDays < days)
                    return false;
            }

            return true;
        }
    }
}