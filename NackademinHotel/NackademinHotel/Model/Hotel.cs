using System.Collections.Generic;

namespace NackademinHotel.Model
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}