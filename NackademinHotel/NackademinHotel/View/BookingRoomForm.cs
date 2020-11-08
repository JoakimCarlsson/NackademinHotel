using System;
using System.Windows.Forms;
using NackademinHotel.Controller;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class BookingRoomForm : Form
    {
        private HotelRoom _hotelRoom;
        private DateTime _startDate;
        private DateTime _endDate;
        private CustomerController _customerController = new CustomerController();
        private BookingController _bookingController = new BookingController();

        public BookingRoomForm(HotelRoom hotelRoom, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            _hotelRoom = hotelRoom;
            _startDate = startDate;
            _endDate = endDate;
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
            extraBedsComboBox.DataSource = _hotelRoom.MaxExtraBeds();
        }

        private void saveBooking_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerListBox.SelectedItem as Customer;
                if (customer == null)
                {
                    MessageBox.Show("Du måste välja kund för att boka", "Fel", MessageBoxButtons.OK);
                }
                else
                {
                    int extraBeds = (int) extraBedsComboBox.SelectedItem;
                    bool payed = payedCheckBox.Checked;
                    if (_bookingController.SaveBooking(customer, _hotelRoom, extraBeds, _startDate, _endDate, payed))
                    {
                        MessageBox.Show("Bokningen är nu genomförd", "Lyckades", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Fel", MessageBoxButtons.OK);
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