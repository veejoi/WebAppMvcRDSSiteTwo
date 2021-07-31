using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppMvcRDSSiteTwo.Models
{
    public partial class Sale
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public decimal Amount { get; set; }
    }
}
