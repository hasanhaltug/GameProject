using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Data.Abstract
{
   public interface IGameData
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        List<Game> GetAll();
    }
}
