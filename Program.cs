using GameMembershipDemo.Entities;
using GameMembershipDemo.Abstract;
using GameMembershipDemo.Concrete;
using GameMembershipDemo.Adapters;

using System;

namespace GameMembershipDemo
{
    class Program
    {
       public static void Main(string[] args)
        {
            User user1 = new User { Id = 1, NationalityId = "11111111", FirstName = "Yunus Emre", LastName = "Demir", DateOfBirth = new DateTime(1900, 1, 1), UserName = "yunuusdemir" };
            Campaign campaign1 = new Campaign { Id = 1001, CampaignName = "WinterFest", CampaignDiscount = 70 };
            Game game1 = new Game { Id = 101, GameName = "Call Of Duty:Black Ops", GamePrice = 789 };


            UserManager userManager = new UserManager(new MernisServiceAdapter());

            userManager.Add(user1);
            
            CampaignManager campaignManager = new CampaignManager();
            
            campaignManager.Add(campaign1);

            GameManager gameManager = new GameManager();

            gameManager.Add(game1);

            SalesManager salesManager = new SalesManager();

            salesManager.Sell(user1,game1,campaign1);

            
        }
    }
}
