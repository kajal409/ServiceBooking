using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceBooking.Models
{
    public partial class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? ZipCode { get; set; }
        public string ContactNo { get; set; }
        public string Password { get; set; }
    }
}
