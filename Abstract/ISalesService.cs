using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Abstract
{
    interface ISalesService
    {
        public void Sell(User user,Game game, Campaign campaign);
    }
}
