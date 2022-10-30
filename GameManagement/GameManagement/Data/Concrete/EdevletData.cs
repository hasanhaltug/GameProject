using GameManagement.Data.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameManagement.Data.Concrete
{
    public class EdevletData : IEdevlet
    {
        List<Edevlet> EdevletDataBase;
        public EdevletData()
        {
            EdevletDataBase = new List<Edevlet>
            {
                new Edevlet {TcNo="12345",FirstName="Hasan",LastName="Altuğ",DateOfBirth=new DateTime(1999, 12, 30)},
                new Edevlet {TcNo="12346",FirstName="Kadir",LastName="Altuğ",DateOfBirth=new DateTime(1998, 10, 24)},
                new Edevlet {TcNo="12347",FirstName="Taha",LastName="Seflek",DateOfBirth=new DateTime(1997, 09, 12)},
                new Edevlet {TcNo="12348",FirstName="Rakif",LastName="Ulgu",DateOfBirth=new DateTime(1996, 05, 11)},
                new Edevlet {TcNo="12349",FirstName="Emre",LastName="Soydan",DateOfBirth=new DateTime(1995, 02, 21)}
            };
        }
        public bool checkGamer(Gamer gamer)
        {
            Edevlet checkGamer = EdevletDataBase.SingleOrDefault(i => i.TcNo == gamer.TcNo & i.FirstName == gamer.FirstName & i.LastName == gamer.LastName & i.DateOfBirth == gamer.DateOfBirth);
            if (checkGamer != null)
            {
                Console.WriteLine("E devlette kayıtlı.");
                return true;
            } 
            else
            {
                Console.WriteLine("E devlette kayıtlı değil.");
                return false;
                
            }
        }
    }
}
