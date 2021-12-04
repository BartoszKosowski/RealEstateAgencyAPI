using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models
{
    public class EstateOffer
    {
        #region offer entity
        public int IdOffers { get; set; }
        public int? Agent { get; set; }
        public DateTime? PublishingDate { get; set; }
        public byte? TradeArea { get; set; }
        public decimal? Price { get; set; }
        public string Details { get; set; }
        public string OfferName { get; set; }
        public decimal? PriceForMeter { get; set; }
        public string OfferType { get; set; }
        public bool? HasRent { get; set; }
        public decimal? RentValue { get; set; }
        #endregion

        #region estate entity
        public string PropertyType { get; set; }
        public decimal? PropertyArea { get; set; }
        public short? BuildDate { get; set; }
        public byte? PropertyStatus { get; set; }
        public short? NumberOfRooms { get; set; }
        public byte? Floors { get; set; }
        public string OtherDetails { get; set; }
        public bool? HasBalcony { get; set; }
        public bool? Furnishings { get; set; }
        public string MainPhotoUrl { get; set; }
        public string RoofType { get; set; }
        public bool? Electricity { get; set; }
        public bool? WaterConnection { get; set; }
        public bool? Basement { get; set; }
        public bool? Garage { get; set; }
        public decimal? Plot { get; set; }
        public bool? Fence { get; set; }
        public string Heating { get; set; }
        public bool? Sewers { get; set; }

        public decimal? DistanceToForest { get; set; }
        public decimal? DistanceToRiver { get; set; }
        public decimal? DistanceToMountains { get; set; }
        public decimal? DistanceToHighway { get; set; }
        public decimal? DistanceToCenter { get; set; }
        public decimal? DistanceToMall { get; set; }
        public decimal? DistanceToLake { get; set; }
        public decimal? DistanceToCoast { get; set; }
        #endregion

        #region address entity
        public string Street { get; set; }
        public string EstateNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string GoogleMapsUrl { get; set; }
        #endregion
    }
}
