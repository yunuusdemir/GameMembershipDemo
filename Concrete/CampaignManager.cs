using GameMembershipDemo.Abstract;
using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi.");
            
            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası'nın bilgileri güncellendi.");
        }
    }

}
