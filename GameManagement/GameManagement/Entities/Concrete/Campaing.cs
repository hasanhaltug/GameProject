using GameManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entities.Concrete
{
    public class Campaing : IEntity
    {
        public int CampaingID { get; set; }
        public string CampaingName { get; set; }
        public double Discount { get; set; }

    }
}
