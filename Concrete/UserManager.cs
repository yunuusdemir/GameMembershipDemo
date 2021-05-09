using GameMembershipDemo.Abstract;
using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Concrete
{
    
    class UserManager : IUserService
    {
        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("Yeni üye eklendi.");
            }
            else
            {
                throw new Exception("Üye bilgileri doğrulanamadı. Lütfen Kontrol ediniz.");
            }
            
        }
        public void Delete(User user)
        {
            Console.WriteLine("Üye silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Üye bilgileri güncellendi.");
        }
    }
}
