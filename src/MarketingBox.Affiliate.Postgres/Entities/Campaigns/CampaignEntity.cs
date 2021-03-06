using System.Collections.Generic;
using MarketingBox.Affiliate.Postgres.Entities.Brands;
using MarketingBox.Affiliate.Postgres.Entities.CampaignBoxes;
using MarketingBox.Affiliate.Service.Domain.Campaigns;

namespace MarketingBox.Affiliate.Postgres.Entities.Campaigns
{
    public class CampaignEntity
    {
        public string TenantId { get; set; }
        public long Id { get; set; }

        public string Name { get; set; }

        public long BrandId { get; set; }

        public BrandEntity Brand { get; set; }

        public Payout Payout { get; set; }

        public Revenue Revenue { get; set; }

        public CampaignStatus Status { get; set; }

        public CampaignPrivacy Privacy { get; set; }

        public long Sequence { get; set; }

        public ICollection<CampaignBoxEntity> CampaignBoxes { get; set; }
    }
}