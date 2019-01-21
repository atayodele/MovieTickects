using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTickets.Data.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string seatNo { get; set; }
        public string UserId { get; set; }
        public DateTime date { get; set; }
        public double Amount { get; set; }
        public int MovieId { get; set; }
    }
}
