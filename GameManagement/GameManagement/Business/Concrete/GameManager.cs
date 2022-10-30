using GameManagement.Business.Abstract;
using GameManagement.Data.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Concrete
{
    public class GameManager : IGameService
    {
        IGameData _gameData;
        public GameManager(IGameData gameData)
        {
            _gameData = gameData;
        }


        public void Add(Game game)
        {
            _gameData.Add(game);
        }

        public void Delete(Game game)
        {
            _gameData.Delete(game);
        }

        public List<Game> GetAll()
        {
            return _gameData.GetAll();
        }

        public void Update(Game game)
        {
            _gameData.Update(game);
        }
    }
}
