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
        CustomerController _customerController = new CustomerController();
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            bookinListBox.DataSource = _bookingController.GetAll();
            bookinListBox.SelectedIndex = -1;

            availableRooms.DataSource = _hotelRoomController.GetAllAvailable();
            availableRooms.SelectedIndex = -1;

            customerComboBox.DataSource = _customerController.GetAll();
        }

        private void saveBookingbutton_Click(object sender, EventArgs e)
        {
            Customer customer = customerComboBox.SelectedItem as Customer;
            HotelRoom hotelRoom = availableRooms.SelectedItem as HotelRoom;
            DateTime startDate = this.startDate.Value;
            DateTime endDate = this.endDate.Value;
            
            if (_bookingController.SaveBooking(customer, hotelRoom, startDate, endDate))
            {
                MessageBox.Show("Bokning är nu genomförd.");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Booking booking = bookinListBox.SelectedItem as Booking;
            if (booking == null)
            {
                MessageBox.Show("Du måste välja en bokning för att kundda redigera", "Fel", MessageBoxButtons.OK);
            }
        }
    }
}