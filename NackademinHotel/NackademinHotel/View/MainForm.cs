using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NackademinHotel.Data;
using NackademinHotel.Model;

namespace NackademinHotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (HotelContext hotelContext = new HotelContext())
            {

            }
        }
    }
}
