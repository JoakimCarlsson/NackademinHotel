using System.Windows.Forms;
using NackademinHotel.Controller;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class BookingEditForm : Form
    {
        private  BookingController _bookingController = new BookingController();
        private Booking _booking;
        
        public BookingEditForm(Booking booking)
        {
            InitializeComponent();
            _booking = booking;
        }
        
        
        
    }
}