using System.Collections.Generic;
using System.Linq;
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

            foreach (HotelRoom hotelRoom in _hotelContext.HotelRooms)
            {
                if (hotelRoom.Bookings != null)
                {
                    foreach (Booking booking in hotelRoom.Bookings)
                    {
                        if (!booking.IsBooked())
                        {
                            hotelRooms.Add(hotelRoom);
                        }
                    }
                }
                hotelRooms.Add(hotelRoom);
            }

            return hotelRooms;
        }

        internal IEnumerable<HotelRoom> GetAll()
        {
            return _hotelContext.HotelRooms;
        }
    }
}