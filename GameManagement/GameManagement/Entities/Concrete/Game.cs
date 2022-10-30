using GameManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entities.Concrete
{
    public class Game : IEntity
    {
        public int GameID { get ; set ; }
        public string GameName { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        //public int CampaingId { get; set; }
    }
}
