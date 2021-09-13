﻿using MarketingBox.Affiliate.Service.MyNoSql.Common;

namespace MarketingBox.Affiliate.Service.MyNoSql.Campaigns
{
    public class Payout
    {
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public Plan Plan { get; set; }
    }
}