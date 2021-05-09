using GameMembershipDemo.Abstract;
using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}
