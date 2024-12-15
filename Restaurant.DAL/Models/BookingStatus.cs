using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Models
{
    public enum BookingStatus
    {
        NoTable,     // no aviable tabels 
        Pending,     // waiting for confirmation 
        Confirmed,   // confirm y email
        Cancelled,   // by user if he didn't confirm the email, or by admin 
        Completed,   // custoner arrived
        NoShow,      // customer didn't arraive 
    }
}
