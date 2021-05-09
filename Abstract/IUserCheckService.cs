using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Abstract
{
    interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
