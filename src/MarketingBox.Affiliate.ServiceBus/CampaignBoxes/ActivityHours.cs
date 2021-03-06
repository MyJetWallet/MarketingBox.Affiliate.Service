using System;
using System.Runtime.Serialization;

namespace MarketingBox.Affiliate.Service.Messages.CampaignBoxes
{
    [DataContract]
    public class ActivityHours
    {
        [DataMember(Order = 1)]
        public DayOfWeek Day { get; set; }

        [DataMember(Order = 2)]
        public bool IsActive { get; set; }

        [DataMember(Order = 3)]
        public DateTime? From { get; set; }

        [DataMember(Order = 4)]
        public DateTime? To { get; set; }
    }
}