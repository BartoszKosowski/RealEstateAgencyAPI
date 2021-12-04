using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models
{
    public class ApartmentOffer
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

        #region apartment entity
        public byte? PropertyState { get; set; }
        public decimal? PropertyArea { get; set; }
        public bool? Furnishings { get; set; }
        public bool? HasBalcony { get; set; }
        public byte? FloorNumber { get; set; }
        public byte? NumberOfRooms { get; set; }
        public bool? HasBathroom { get; set; }
        public bool? ParkingSpace { get; set; }
        public string Heating { get; set; }
        public string InsideDesign { get; set; }
        public string KitchenEquipment { get; set; }
        public string BathroomEquipment { get; set; }
        public string BuildingName { get; set; }
        public int? BuildYear { get; set; }
        public string BuildingType { get; set; }
        public byte? NumberOfFloors { get; set; }

        public decimal? DistanceToForest { get; set; }
        public decimal? DistanceToRiver { get; set; }
        public decimal? DistanceToMountains { get; set; }
        public decimal? DistanceToHighway { get; set; }
        public decimal? DistanceToCenter { get; set; }
        public decimal? DistanceToMall { get; set; }
        public decimal? DistanceToLake { get; set; }
        public decimal? DistanceToCoast { get; set; }
        public string OtherDetails { get; set; }
        #endregion

        #region address entity
        public string Street { get; set; }
        public string EstateNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string GoogleMapsUrl { get; set; }

        #endregion

    }
}
