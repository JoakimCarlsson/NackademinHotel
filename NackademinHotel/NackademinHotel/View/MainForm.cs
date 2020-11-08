using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NackademinHotel.Controller;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class MainForm : Form
    {
        private CustomerController _customerController;
        private BookingController _bookingController;
        private HotelRoomController _hotelRoomController;
        public MainForm()
        {
            InitializeComponent();
            _customerController = new CustomerController();
            _bookingController = new BookingController();
            _hotelRoomController = new HotelRoomController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            customerListBox.DataSource = _customerController.GetAll();
            bookingsListbox.DataSource = _bookingController.GetAllActive();
            availableRoomsListbox.DataSource = _hotelRoomController.GetAllAvailable();

            customerListBox.SelectedIndex = -1;
            bookingsListbox.SelectedIndex = -1;
            availableRoomsListbox.SelectedIndex = -1;
        }

        private void registerCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void manageBookings_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }
    }
}
