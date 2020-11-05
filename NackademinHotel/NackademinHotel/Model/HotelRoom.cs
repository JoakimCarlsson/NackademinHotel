using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace NackademinHotel.Model
{
    public class HotelRoom
    {
        public int Id { get; private set; }
        public int RoomNumber { get; private set; }
        public double RoomSize { get; private set; }
        public bool DoubleRoom { get; private set; }
        public int ExtraBeds { get; private set; }
        public int HotelId { get; private set; }
        public Hotel Hotel { get; private set; }
        public ICollection<Booking>? Bookings { get; private set; }

        public HotelRoom()
        {
            
        }
        
        public HotelRoom(int roomNumber, double roomSize,  Hotel hotel, int extraBeds ,bool doubleRoom = false)
        {
            RoomNumber = roomNumber;
            RoomSize = roomSize;
            DoubleRoom = doubleRoom;
            ExtraBeds = extraBeds;
            Hotel = hotel;
        }
        
        public override string ToString()
        {
            return $"Nummer: {RoomNumber}, Storlek: {RoomSize}, Double Rum: {(DoubleRoom ? "Ja" : "Nej")}";
        }

        internal int MaxExtraBeds(HotelRoom room)
        {
            if (!room.DoubleRoom)
                return 0;

            if (room.RoomSize >= 10 && room.RoomSize <= 15)
                return 1;

            if (room.RoomSize >= 15)
                return 2;

            return 0;
        }
    }
}