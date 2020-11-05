using System;
using System.Windows.Forms;
using NackademinHotel.Controller;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class BookingForm : Form
    {
        BookingController _bookingController = new BookingController();
        HotelRoomController _hotelRoomController = new HotelRoomController();
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            bookinListBox.DataSource = _bookingController.GetAll();
            bookinListBox.SelectedIndex = -1;

            GetRoomsAvailable();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Booking booking = bookinListBox.SelectedItem as Booking;
            if (booking == null)
            {
                MessageBox.Show("Du måste välja en bokning för att kundda redigera", "Fel", MessageBoxButtons.OK);
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            GetRoomsAvailable();
        }

        private void endDate_ValueChanged_1(object sender, EventArgs e)
        {
            GetRoomsAvailable();
        }

        private void GetRoomsAvailable()
        {
            availableRooms.DataSource = _hotelRoomController.GetAllAvailableBetweenDates(startDate.Value, endDate.Value);
            availableRooms.SelectedIndex = -1;
        }

        private void bookRoom_Click(object sender, EventArgs e)
        {
            HotelRoom hotelRoom = availableRooms.SelectedItem as HotelRoom;
            if (hotelRoom == null)
            {
                MessageBox.Show("Du måste måsta först välja ett rum.");
            }
            else
            {
                BookingRoomForm bookingRoomForm = new BookingRoomForm(hotelRoom);
                bookingRoomForm.Show();
            }
        }
    }
}