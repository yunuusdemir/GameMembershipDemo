using GameMembershipDemo.Abstract;
using GameMembershipDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} oyunu eklendi.",game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} oyunu Silindi.", game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} bilgileri güncellendi.", game.GameName);
        }
    }
}
