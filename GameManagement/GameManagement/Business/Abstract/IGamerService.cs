using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Abstract
{
    public interface IGamerService
    {
        List<Gamer> GetAll();
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);


    }
}
