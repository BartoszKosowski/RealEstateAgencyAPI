using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class Photo
    {
        public int IdPhoto { get; set; }
        public int? Estate { get; set; }
        public int? Apartment { get; set; }
        public string PhotoUrl { get; set; }

        public virtual Estate EstateNavigation { get; set; }
        public virtual Apartment ApartmentNavigation { get; set; }
    }
}
