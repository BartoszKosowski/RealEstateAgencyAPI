using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models
{
    public class ApartmentOfferPreview
    {
        public int IdOffer { get; }
        public int Agent { get; }
        public string Name { get; }
        public string Street { get; }
        public string City { get; }
        public string District { get; set; }
        public decimal? Price { get; }
        public decimal? Area { get; }
        public decimal? PriceForMeter { get; }
        public string OfferType { get; }
        public int? NumberOfRooms { get; }
        public string InsideDesign { get; }
        public string MainPhotoUrl { get; }
        public byte? OfferStatus { get; }
        public bool? HasRent { get; }
        public decimal? RentValue { get; }
    }
}
