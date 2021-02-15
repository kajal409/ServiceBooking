using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceBooking.Models
{
    public partial class Mechanic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MechanicNo { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
    }
}
