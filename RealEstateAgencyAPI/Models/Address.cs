using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class Address
    {
        public Address()
        {
            Estates = new HashSet<Estate>();
            Apartments = new HashSet<Apartment>();
        }

        public int IdAddress { get; set; }
        public string Street { get; set; }
        public string EstateNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string GoogleMapsUrl { get; set; }
        public string District { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
