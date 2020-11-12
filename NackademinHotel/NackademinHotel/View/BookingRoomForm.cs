using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using NackademinHotel.Controller;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class BookingRoomForm : Form
    {
        private HotelRoom _hotelRoom;
        private int _peopleAmount;
        private DateTime _startDate;
        private DateTime _endDate;
        private CustomerController _customerController = new CustomerController();
        private BookingController _bookingController = new BookingController();

        public BookingRoomForm(HotelRoom hotelRoom, DateTime startDate, DateTime endDate, int people)
        {
            InitializeComponent();
            _hotelRoom = hotelRoom;
            _startDate = startDate;
            _endDate = endDate;
            _peopleAmount = people;
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
            extraBedsNumeric.Enabled = false;

            roomSizeTextBox.Text = _hotelRoom.RoomSize.ToString();
            roomsNumberTextBox.Text = _hotelRoom.RoomNumber.ToString();
            doubleRoomTextBox.Text = _hotelRoom.DoubleRoom ? "Ja" : "Nej";
            extraBedsNumeric.Value = GetExtraBedsAmount();
        }

        private int GetExtraBedsAmount()
        {
            if (!_hotelRoom.DoubleRoom)
                return 0;

            if (_hotelRoom.RoomSize >= 10 && _hotelRoom.RoomSize <= 15)
                if (_peopleAmount > 2)
                    return 1;

            if (_hotelRoom.RoomSize >= 15)
            {
                if (_peopleAmount == 3)
                    return 1;

                if (_peopleAmount == 4)
                    return 2;
            }

            return 0;
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
                    bool payed = payedCheckBox.Checked;
                    if (_bookingController.SaveBooking(customer, _hotelRoom, _peopleAmount, _startDate, _endDate, payed))
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