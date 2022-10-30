using GameManagement.Business.Abstract;
using GameManagement.Data.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IDataBase _dataBase;
    
        public GamerManager(IDataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public void Add(Gamer gamer)
        {
            _dataBase.Add(gamer);
        }

        public void Delete(Gamer gamer)
        {
            _dataBase.Delete(gamer);
        }

        public List<Gamer> GetAll()
        {
            return _dataBase.GetAll();
        }

        public void Update(Gamer gamer)
        {
            _dataBase.Update(gamer);
        }
    }
}
