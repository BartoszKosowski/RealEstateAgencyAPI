﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models
{
    public class OfferPreview
    {
        public string Name { get; }
        public string Street { get; }
        public string City { get; }
        public decimal? Price { get; }
        public decimal? Area { get; }
        public decimal? PriceForMeter { get; }
        public string OfferType { get; }
        public int? NumberOfRooms { get; }
        public string PropertyType { get; }
        public string MainPhotoUrl { get; }
        public byte? OfferStatus { get; }

    }
}