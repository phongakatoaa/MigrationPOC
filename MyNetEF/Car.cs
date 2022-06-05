using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MyNetEF
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
    }
}
