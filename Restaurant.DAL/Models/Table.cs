using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public int capacity { get; set; }
        
        [StringLength(50)]
        public string Location { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
