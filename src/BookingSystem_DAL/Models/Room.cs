using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem_DAL.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
