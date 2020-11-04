using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class CustomerController
    {
        private HotelContext _hotelContext;

        public bool CreateNewCustomer(string firstName, string lastName, DateTime socialSecurityNumber)
        {
            try
            {
                Customer customer = new Customer(firstName, lastName, socialSecurityNumber);

                using (_hotelContext = new HotelContext())
                {
                    _hotelContext.Add(customer);
                    _hotelContext.SaveChanges();
                }
            
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fel", MessageBoxButtons.OK);
                return false;
            }
        }

        public bool RemoveCustomer(Customer customer)
        {
            if (customer.Bookings.Count != 0)
                return false;

            using (_hotelContext = new HotelContext())
            {
                _hotelContext.Customers.Remove(customer);
                _hotelContext.SaveChanges();
                return true;
            }
        }

        public bool EditCustomer(Customer customer, string firstName, string lastName, DateTime dateOfBirth)
        {
            customer.ChangeFirstName(firstName);
            customer.ChangeLastName(lastName);
            customer.ChangeDateOfBirth(dateOfBirth);
            
            using (_hotelContext = new HotelContext())
            {
                _hotelContext.Customers.Update(customer);
                _hotelContext.SaveChanges();
                return true;
            }
        }

        public List<Customer> GetAll()
        {
            using (_hotelContext = new HotelContext())
            {
                return _hotelContext.Customers.Include(c => c.Bookings).ToList();
            }
        }
    }
}