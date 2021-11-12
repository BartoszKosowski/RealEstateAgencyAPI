using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class Meeting
    {
        public int IdMeetings { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public int? Agent { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerEmail { get; set; }
        public bool? InEstate { get; set; }
        public int? EstateAddress { get; set; }
        public string OtherAddress { get; set; }
        public byte? Status { get; set; }

        public virtual Agent AgentNavigation { get; set; }
        public virtual Address EstateAddressNavigation { get; set; }
        public virtual Status StatusNavigation { get; set; }
    }
}
