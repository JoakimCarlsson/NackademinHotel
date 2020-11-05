using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class HotelRoomController
    {
        private HotelContext _hotelContext = new HotelContext();

        internal IEnumerable<HotelRoom> GetAllAvailable()
        {
            List<HotelRoom> hotelRooms = new List<HotelRoom>();

            foreach (HotelRoom hotelRoom in _hotelContext.HotelRooms.Include(b => b.Bookings))
            {
                if (hotelRoom.Bookings.Count != 0)
                {
                    foreach (Booking booking in hotelRoom.Bookings)
                    {
                        if (!booking.IsBooked())
                        {
                            hotelRooms.Add(hotelRoom);
                        }
                        
                    }
                }
                else
                {
                    hotelRooms.Add(hotelRoom);
                }
            }

            return hotelRooms;
        }

        internal IEnumerable<HotelRoom> GetAll()
        {
            return _hotelContext.HotelRooms;
        }
    }
}