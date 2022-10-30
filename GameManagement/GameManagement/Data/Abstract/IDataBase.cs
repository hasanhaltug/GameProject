using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Data.Abstract
{
    public interface IDataBase
    {
        
        List<Gamer> GetAll();
        void Add(Gamer parametergamer);
        void Delete(Gamer parametergamer);
        void Update(Gamer parametergamer);
    }
}
