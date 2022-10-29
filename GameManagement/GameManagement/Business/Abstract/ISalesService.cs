using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Abstract
{
    public interface ISalesService
    {
        void Sell(Gamer gamer, Game game, Campaing campaing);
    }
}
