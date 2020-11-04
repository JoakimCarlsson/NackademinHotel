using System;
using System.Windows.Forms;
using NackademinHotel.Controller;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class CustomerForm : Form
    {
        private CustomerController _customerController = new CustomerController();        
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerListBox();
        }

        private void saveCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedItem is Customer)
            {
                EditCustomer();
            }
            else
            {
                CreateNewCustomer();
            }

        }

        private void EditCustomer()
        {
            if (_customerController.EditCustomer(customerListBox.SelectedItem as Customer, firstNameTextBox.Text, lastNameTextBox.Text, dateOfBirthPicker.Value))
            {
                MessageBox.Show("Sparat", "Lyckades", MessageBoxButtons.OK);
                LoadCustomerListBox();
                ResetFormInput();
            }
        }

        private void CreateNewCustomer()
        {
            if (_customerController.CreateNewCustomer(firstNameTextBox.Text, lastNameTextBox.Text, dateOfBirthPicker.Value))
            {
                MessageBox.Show("Ny kund har nu sparats", "Lyckades", MessageBoxButtons.OK);
                LoadCustomerListBox();
                ResetFormInput();
            }
        }

        private void LoadCustomerListBox()
        {
            customerListBox.DataSource = _customerController.GetAll();
            customerListBox.SelectedIndex = -1;
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            if (_customerController.RemoveCustomer(customerListBox.SelectedItem as Customer))
            {
                MessageBox.Show("Kund har nu raderats", "Lyckades", MessageBoxButtons.OK);
                LoadCustomerListBox();
            }
            else
            {
                MessageBox.Show("Du kan inte ta bort en kund som har bokningar.", "Lyckades", MessageBoxButtons.OK);
            }
        }

        private void ResetFormInput()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateOfBirthPicker.Value = DateTime.Now;
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = customerListBox.SelectedItem as Customer;
            if (customer == null)
            {
                MessageBox.Show("Du måste välja en person att redigera");
            }
            else
            {
                firstNameTextBox.Text = customer.FirstName;
                lastNameTextBox.Text = customer.LastName;
                dateOfBirthPicker.Value = customer.SocialSecurityNumber;
            }
        }
    }
}