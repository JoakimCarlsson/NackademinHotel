using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class HotelRoomController
    {
        private HotelContext _hotelContext;

        internal IEnumerable<HotelRoom> GetAllAvailable()
        {
            List<HotelRoom> hotelRooms = new List<HotelRoom>();

            using (_hotelContext = new HotelContext())
            {
                foreach (HotelRoom hotelRoom in _hotelContext.HotelRooms.Include(b => b.Bookings))
                {
                    if (hotelRoom.IsAviable())
                    {
                        hotelRooms.Add(hotelRoom);
                    }
                }

                return hotelRooms;
            }
        }

        internal IEnumerable<HotelRoom> GetAll()
        {
            return _hotelContext.HotelRooms;
        }

        internal IEnumerable<HotelRoom> GetAllAvailableBetweenDates(DateTime startDate, DateTime endDate)
        {
            List<HotelRoom> tmpList = new List<HotelRoom>();
            using (_hotelContext = new HotelContext())
            {
                foreach (HotelRoom hotelRoom in _hotelContext.HotelRooms.Include(h => h.Bookings))
                {
                    if (hotelRoom.Bookings.Count == 0)
                    {
                        tmpList.Add(hotelRoom);
                        continue;
                    }

                    foreach (Booking hotelRoomBooking in hotelRoom.Bookings)
                    {
                        if(startDate <= hotelRoomBooking.StartBookDate && endDate <= hotelRoomBooking.StartBookDate || startDate >= hotelRoomBooking.EndBookDate && endDate >= hotelRoomBooking.EndBookDate || hotelRoomBooking.Annulled)
                        {
                            tmpList.Add(hotelRoom);
                        }
                    }
                }
            }

            return tmpList;
        }
    }
}