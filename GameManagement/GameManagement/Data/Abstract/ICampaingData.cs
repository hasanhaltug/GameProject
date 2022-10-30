using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Data.Abstract
{
    public interface ICampaingData
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
        List<Campaing> GetAll();
    }
}
