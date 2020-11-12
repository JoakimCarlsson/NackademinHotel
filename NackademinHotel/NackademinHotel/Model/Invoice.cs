using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NackademinHotel.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        [Required]
        public DateTime BookedDate { get; private set; }
        [Required]
        public bool Payed { get; private set; }

        public Invoice()
        {
            
        }

        public Invoice(DateTime dateTime, bool payed)
        {
            BookedDate = dateTime;
            Payed = payed;
        }

        public void SetPaid(bool paid)
        {
            Payed = paid;
        }
    }
}
