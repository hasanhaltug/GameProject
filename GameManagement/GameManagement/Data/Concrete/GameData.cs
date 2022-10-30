using GameManagement.Data.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameManagement.Data.Concrete
{
    public class GameData : IGameData
    {
        List<Game> _game;
        public GameData()
        {
            _game = new List<Game>
            {
                new Game{GameID=1,GameName="Valorant",Description="Strategic gun game.", UnitPrice=100},
                new Game{GameID=2,GameName="CS-GO",Description="Gun game.", UnitPrice=150}
            };
        }
        public void Add(Game game)
        {
            bool check = true;
            foreach (var item in _game)
            {
                if(item.GameID==game.GameID)
                {
                    check = false;
                    break;
                }

            }
            if(check)
            {
                _game.Add(game);
                Console.WriteLine("Game succesfull added.");
            }
            else
            {
                Console.WriteLine("The game id already exists.");
            }
        }

        public void Delete(Game game)
        {
            Game gameDelete = _game.SingleOrDefault(i => i.GameID == game.GameID);
            _game.Remove(gameDelete);
        }

        public List<Game> GetAll()
        {
            return _game;
        }

        public void Update(Game game)
        {
            Game gameUpdate = _game.SingleOrDefault(i => i.GameID == game.GameID);
            gameUpdate.GameName = game.GameName;
            gameUpdate.Description = game.Description;
            gameUpdate.UnitPrice = game.UnitPrice;
        }
    }
}
