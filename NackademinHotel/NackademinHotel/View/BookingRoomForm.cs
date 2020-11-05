using System;
using System.Windows.Forms;
using NackademinHotel.Controller;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class BookingRoomForm : Form
    {
        private HotelRoom _hotelRoom;
        private CustomerController _customerController = new CustomerController();
        private BookingController _bookingController = new BookingController();
        public BookingRoomForm(HotelRoom hotelRoom)
        {
            InitializeComponent();
            _hotelRoom = hotelRoom;
        }

        private void BookingRoomForm_Load(object sender, EventArgs e)
        {
            UpdateCustomerListBox();
            SetupRoomInformation();
        }

        private void UpdateCustomerListBox()
        {
            customerListBox.DataSource = _customerController.GetAll();
            customerListBox.SelectedIndex = -1;
        }

        private void SetupRoomInformation()
        {
            roomSizeTextBox.Enabled = false;
            roomsNumberTextBox.Enabled = false;
            doubleRoomTextBox.Enabled = false;

            roomSizeTextBox.Text = _hotelRoom.RoomSize.ToString();
            roomsNumberTextBox.Text = _hotelRoom.RoomNumber.ToString();
            doubleRoomTextBox.Text = _hotelRoom.DoubleRoom ? "Ja" : "Nej";
            extraBedsTextBot.Text = _hotelRoom.ExtraBeds.ToString();
        }

        private void saveBooking_Click(object sender, EventArgs e)
        {
            Customer customer = customerListBox.SelectedItem as Customer;
            if (customer == null)
            {
                MessageBox.Show("Du måste välja kund för att boka", "Fel", MessageBoxButtons.OK);
                return;
            }

            if (_hotelRoom.MaxExtraBeds() < Convert.ToInt32(extraBedsTextBot.Text))
            {
                MessageBox.Show("För många extra sängar, rum över 20m2 kan ha 2, annars 1.", "Fel", MessageBoxButtons.OK);
                return;
            }
            
            
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.FormClosed += customerForm_FormClosed;
            customerForm.Show();
        }

        private void customerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateCustomerListBox();
        }
    }
}