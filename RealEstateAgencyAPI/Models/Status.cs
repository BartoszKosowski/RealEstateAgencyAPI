using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class Status
    {
        public Status()
        {
            Estates = new HashSet<Estate>();
            Meetings = new HashSet<Meeting>();
            Offers = new HashSet<Offer>();
        }

        public byte IdStatus { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Domain { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
        public virtual ICollection<Meeting> Meetings { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
