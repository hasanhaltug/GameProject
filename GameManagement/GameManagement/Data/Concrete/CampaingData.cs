using GameManagement.Data.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameManagement.Data.Concrete
{
    public class CampaingData : ICampaingData
    {
        List<Campaing> _campaings;
        public CampaingData()
        {
            _campaings = new List<Campaing>
            {
                new Campaing {CampaingID=1,CampaingName="Christmas sale",Discount=0.2},
                new Campaing {CampaingID=2,CampaingName="Holiday discount",Discount=0.15}
            };
        }

        public void Add(Campaing campaing)
        { //Linq ile nası yapabilirz sor
            bool result = true;
            foreach (var item in _campaings)
            {
                if(item.CampaingID==campaing.CampaingID)
                {
                    result = false;
                    break;
                }
            }
            if(result)
            {
                _campaings.Add(campaing);
                Console.WriteLine("Campaing added.");
            }
            else
            {
                Console.WriteLine("Campaing already exists");
            }
            
        }

        public void Delete(Campaing campaing)
        {
            Campaing campaingDelete= _campaings.SingleOrDefault(i=>i.CampaingID==campaing.CampaingID);
            _campaings.Remove(campaingDelete);
        }

        public List<Campaing> GetAll()
        {
            return _campaings;
        }

        public void Update(Campaing campaing)
        {
            Campaing campaingUpdate = _campaings.SingleOrDefault(i => i.CampaingID == campaing.CampaingID);
            campaingUpdate.CampaingName = campaing.CampaingName;
            campaingUpdate.Discount = campaing.Discount;
        }


    }
}
