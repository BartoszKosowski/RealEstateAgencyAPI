using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models
{
    public class Apartment
    {
        public Apartment()
        {
            Offers = new HashSet<Offer>();
            Photos = new HashSet<Photo>();
        }

        public int IdApartment { get; set; }
        public int? Address { get; set; }
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
        public string MainPhotoUrl { get; set; }

        public bool? NearForest { get; set; }
        public bool? NearRiver { get; set; }
        public bool? NearMountains { get; set; }
        public bool? NearHighway { get; set; }
        public bool? NearCenter { get; set; }
        public bool? NearMall { get; set; }
        public bool? NearLake { get; set; }
        public bool? NearCoast { get; set; }
        public string OtherDetails { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual Status StatusNavigation { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
