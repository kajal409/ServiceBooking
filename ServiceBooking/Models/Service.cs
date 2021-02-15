using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceBooking.Models
{
    public partial class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public int Price { get; set; }
        public DateTime Duration { get; set; }
        public string Active { get; set; }
    }
}
