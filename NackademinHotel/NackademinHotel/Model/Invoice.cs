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
        public DateTime BookedDate { get; set; }
        [Required]
        public bool Payed { get; set; }
    }
}
