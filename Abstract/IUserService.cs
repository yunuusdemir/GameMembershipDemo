using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Abstract
{
   public interface IUserService
    {

        public void Add(User user);
        public void Delete(User user);
        public void Update(User user);

       // public void Buy(User user,ISalesService salesService);
    }
}
