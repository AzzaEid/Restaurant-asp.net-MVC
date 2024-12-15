using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Models
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }
        
        [Required,StringLength(100), EmailAddress]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        public DateTime BookingDate { get; set; } 
        public TimeSpan BookingTime { get; set; }
        public int NumberOfGuestes { get; set; }
        public int TableId { get; set; }   
        public BookingStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ConfirmationDeadline { get; set; } 

    }


}
