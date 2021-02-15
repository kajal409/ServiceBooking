using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceBooking.Models
{
    public partial class Vehical
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ChasisNo { get; set; }
        public string OwnerName { get; set; }
    }
}
