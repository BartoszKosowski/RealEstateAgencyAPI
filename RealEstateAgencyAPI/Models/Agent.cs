using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class Agent
    {
        public Agent()
        {
            Offers = new HashSet<Offer>();
        }

        public int IdAgents { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public byte Area { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }

        public virtual TradeInfo AreaNavigation { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
