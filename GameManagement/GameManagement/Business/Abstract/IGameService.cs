using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Abstract
{
    public interface IGameService
    {
        List<Game> GetAll();
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
