using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models
{
    public partial class Request
    {
        public int IdRequest { get; set; }
        public string Name { get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public byte Service { get; set; }
        public byte Status { get; set; }

        public virtual TradeInfo ServiceNavigation { get; set; }
        public virtual Status StatusNavigation { get; set; }
    }
}
