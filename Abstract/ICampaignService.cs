using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Abstract
{
    interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Delete(Campaign campaign);
        public void Update(Campaign campaign);
    }
}
