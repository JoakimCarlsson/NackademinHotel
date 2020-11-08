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
        public int HotelId { get; private set; }
        public Hotel Hotel { get; private set; }
        public ICollection<Booking>? Bookings { get; private set; }

        public HotelRoom()
        {
        }

        public HotelRoom(int roomNumber, double roomSize, Hotel hotel, bool doubleRoom = false)
        {
            RoomNumber = roomNumber;
            RoomSize = roomSize;
            DoubleRoom = doubleRoom;
            Hotel = hotel;
        }

        public override string ToString()
        {
            return $"Nummer: {RoomNumber}, Storlek: {RoomSize}, Double Rum: {(DoubleRoom ? "Ja" : "Nej")}";
        }

        internal int[] MaxExtraBeds()
        {
            if (!DoubleRoom)
                return new []{0};

            if (RoomSize >= 10 && RoomSize <= 15)
                return new []{0,1};

            if (RoomSize >= 15)
                return new []{0,1,2};

            return new []{0};
        }

        internal bool IsAviable()
        {
            if (Bookings.Count != 0)
            {
                foreach (Booking booking in Bookings)
                {
                    if (!booking.IsBooked())
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }

            return false;
        }
    }
}