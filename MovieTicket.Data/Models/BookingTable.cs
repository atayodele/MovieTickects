using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieTickets.Data.Models
{
    public class BookingTable
    {
        public int Id { get; set; }
        public string seatno { get; set; }
        public string UserId { get; set; }
        public DateTime Datetopresent { get; set; }
        public int MovieDetailsId { get; set; }
        public double Amount { get; set; }

        [ForeignKey("MovieDetailsId")]
        public virtual MovieDetails moviedetails { get; set; }
    }
}
