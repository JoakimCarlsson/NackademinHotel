using System;
using System.Collections.Generic;

namespace NackademinHotel.Model
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public double RoomSize { get; set; }
        public bool DoubleRoom { get; set; }
        public int ExtraBeds { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Booking>? Bookings { get; set; }

        public override string ToString()
        {
            return $"Nummer: {RoomNumber}, Storlek: {RoomSize}, Double Rum: {(DoubleRoom ? "Ja" : "Nej")}";
        }
    }
}