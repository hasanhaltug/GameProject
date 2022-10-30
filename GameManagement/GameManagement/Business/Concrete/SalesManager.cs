using GameManagement.Business.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Game game, Campaing campaing)
        {
            if(campaing != null)
            {
                double discount = (campaing.Discount * game.UnitPrice );
                game.UnitPrice -= discount;
                Console.WriteLine("The game name: {0} \n User: {1} \n UnitPrice: {2}",game.GameName,gamer.UserName,game.UnitPrice);
            }
            else
            {
                Console.WriteLine("The game name: {0} \n User: {1} \n UnitPrice: {2}",game.GameName,gamer.UserName,game.UnitPrice);
            }
        }
    }
}
