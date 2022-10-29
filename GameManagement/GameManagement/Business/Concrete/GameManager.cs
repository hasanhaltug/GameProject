using GameManagement.Business.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated");
        }
    }
}
