using GameManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entities.Concrete
{
    public class Campaing : IEntity
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double Discount { get; set; }

    }
}
