using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class Estate
    {
        public Estate()
        {
            Offers = new HashSet<Offer>();
            Photos = new HashSet<Photo>();
        }

        public int IdEstate { get; set; }
        public int? Address { get; set; }
        public byte? PropertyType { get; set; }
        public decimal? PropertyArea { get; set; }
        public short? BuildDate { get; set; }
        public byte? PropertyStatus { get; set; }
        public short? NumberOfRooms { get; set; }
        public byte? Floors { get; set; }
        public bool? NearForest { get; set; }
        public bool? NearRiver { get; set; }
        public bool? NearMountains { get; set; }
        public bool? NearHighway { get; set; }
        public bool? NearCenter { get; set; }
        public bool? NearMall { get; set; }
        public bool? NearLake { get; set; }
        public bool? NearCoast { get; set; }
        public decimal? DistanceToForest { get; set; }
        public decimal? DistanceToRiver { get; set; }
        public decimal? DistanceToMountains { get; set; }
        public decimal? DistanceToHighway { get; set; }
        public decimal? DistanceToCenter { get; set; }
        public decimal? DistanceToMall { get; set; }
        public decimal? DistanceToLake { get; set; }
        public decimal? DistanceToCoast { get; set; }
        public string OtherDetails { get; set; }
        public bool? HasBalcony { get; set; }
        public string TypeOfBathroom { get; set; }
        public bool? Furnishings { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual Status PropertyStatusNavigation { get; set; }
        public virtual TradeInfo PropertyTypeNavigation { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
