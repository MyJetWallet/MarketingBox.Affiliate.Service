using System.Runtime.Serialization;
using Destructurama.Attributed;

namespace MarketingBox.Affiliate.Service.Grpc.Models.Partners
{
    [DataContract]
    public class PartnerCompany
    {
        [DataMember(Order = 1)]
        [LogMasked(PreserveLength = false)]
        public string Name { get; set; }

        [DataMember(Order = 2)]
        [LogMasked(PreserveLength = false)]
        public string Address { get; set; }

        [DataMember(Order = 3)]
        [LogMasked(PreserveLength = false)]
        public string RegNumber { get; set; }

        [DataMember(Order = 4)]
        [LogMasked(PreserveLength = false)]
        public string VatId { get; set; }
    }
}