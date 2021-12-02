using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class Offer
    {
        public int IdOffers { get; set; }
        public int? Estate { get; set; }
        public int? Agent { get; set; }
        public DateTime? PublishingDate { get; set; }
        public byte? Area { get; set; }
        public decimal? Price { get; set; }
        public byte? OfferStatus { get; set; }
        public int? Views { get; set; }
        public bool? Promoted { get; set; }
        public string Details { get; set; }
        public string Name { get; set; }
        public decimal? PriceForMeter { get; set; }
        public string OfferType { get; set; }
        public int? Apartment { get; set; }
        public bool? HasRent { get; set; }
        public decimal? RentValue { get; set; }
        public bool? IsEstate { get; set; }

        public virtual Agent AgentNavigation { get; set; }
        public virtual TradeInfo AreaNavigation { get; set; }
        public virtual Estate EstateNavigation { get; set; }
        public virtual Status OfferStatusNavigation { get; set; }
        public virtual Apartment ApartmentNavigation { get; set; }
    }
}
