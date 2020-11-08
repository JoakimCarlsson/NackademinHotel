using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Update;
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

        private void BookingEditForm_Load(object sender, EventArgs e)
        {
            LoadBookingInformation();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill spara?", "?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int extraBeds = (int)extraBedsComboBox.SelectedItem;
                    if (_bookingController.UpdateBooking(_booking, startDatePicker.Value, endTimePicker.Value, payedCheckBox.Checked,extraBeds))
                    {
                        MessageBox.Show("Sparat");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Fel", MessageBoxButtons.OK);
            }
        }
        
        private void LoadBookingInformation()
        {
            roomNumberTextBox.Enabled = false;
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            dateOfBirthPicker.Enabled = false;
            anulledCheckBox.Enabled = false;

            startDatePicker.Value = _booking.StartBookDate;
            endTimePicker.Value = _booking.EndBookDate;
            roomNumberTextBox.Text = _booking.HotelRoom.RoomNumber.ToString();
            extraBedsComboBox.DataSource = _booking.HotelRoom.MaxExtraBeds();
            extraBedsComboBox.SelectedItem = _booking.ExtraBeds.Value;
            payedCheckBox.Checked = _booking.Invoice.Payed;

            firstNameTextBox.Text = _booking.Customer.FirstName;
            lastNameTextBox.Text = _booking.Customer.LastName;
            dateOfBirthPicker.Value = _booking.Customer.SocialSecurityNumber;
            anulledCheckBox.Checked = _booking.Annulled;
        }

        private void cancelBooking_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att avboka?", "?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_bookingController.CancelBooking(_booking))
                {
                    MessageBox.Show("Sparat");
                }
            }
        }
    }
}