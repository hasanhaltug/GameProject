using GameManagement.Data.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameManagement.Data.Concrete
{
    public class DataBase : IDataBase
    {
        IEdevlet _edevlet;
        List<Gamer> gamers;
        public DataBase(IEdevlet edevlet)
        {
            _edevlet = edevlet;
        
            
        
            gamers = new List<Gamer>
            {
                new Gamer {TcNo="12345",FirstName="Hasan",LastName="Altuğ",UserName="hsn",Email="Hasan@gmail.com",Password="12345",DateOfBirth=new DateTime(1999, 12, 31)}
            };
        }
        

        public void Add(Gamer parametergemer)
        {
            bool check = _edevlet.checkGamer(parametergemer);
            if (check)
            {
                Gamer checkGamer = gamers.SingleOrDefault(i => i.TcNo == parametergemer.TcNo & i.UserName == parametergemer.UserName);
                if (checkGamer == null)
                {
                    gamers.Add(parametergemer);
                    Console.WriteLine("gamer is added");
                }
                else
                {
                    Console.WriteLine("User name or Tc already exists. Try again!");
                }
            }
            else
            {
                Console.WriteLine("No such person is registered in the Edevlet.");
            }
        }

        public void Delete(Gamer parametergamer)
        {
            Gamer gamerDelete = gamers.SingleOrDefault(i=>i.TcNo == parametergamer.TcNo);
            gamers.Remove(gamerDelete);
        }

        public List<Gamer> GetAll()
        {
            return gamers;
        }

        public void Update(Gamer parametergamer)
        {
            Gamer gamerUpdate = gamers.SingleOrDefault(i => i.TcNo == parametergamer.TcNo & i.UserName == parametergamer.UserName);
            gamerUpdate.FirstName = parametergamer.FirstName;
            gamerUpdate.LastName = parametergamer.LastName;
            gamerUpdate.Email = parametergamer.Email;
            gamerUpdate.Password = parametergamer.Password;
        }
    }
}
