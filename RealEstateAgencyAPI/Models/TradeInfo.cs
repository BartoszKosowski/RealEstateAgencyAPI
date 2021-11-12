using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class TradeInfo
    {
        public TradeInfo()
        {
            Agents = new HashSet<Agent>();
            Estates = new HashSet<Estate>();
            Offers = new HashSet<Offer>();
        }

        public byte IdInfo { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<Estate> Estates { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
