using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing camaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
        Campaing GetById(int campaignId);


    }
}
