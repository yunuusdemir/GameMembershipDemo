using GameMembershipDemo.Abstract;
using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sell(User user, Game game,Campaign campaign)
        {
            if (campaign.CampaignDiscount > 0 && campaign.CampaignDiscount<=100)
            {
                Console.WriteLine(user.UserName + " kullanıcı adlı üye " + game.GameName + " oyununu %"+campaign.CampaignDiscount+" indirim ile " + Math.Round((game.GamePrice - (game.GamePrice*70)/100)) + " TL karşılığında satın aldı.");
            }
            else
            {
                Console.WriteLine(user.UserName + " kullanıcı adlı üye " + game.GameName + " oyununu " + game.GamePrice + " TL karşılığında satın aldı.");
            }
            
        }
    }
}
