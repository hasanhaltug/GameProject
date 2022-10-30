using GameManagement.Business.Concrete;
using GameManagement.Data.Concrete;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.ConsoleUI
{
    class GameProjectConsole
    {
        static void Main (string[] args)
        {

            Gamer newgamer = new Gamer
            {
                TcNo = "12346",
                FirstName = "Kadir",
                LastName = "Altuğ",
                UserName = "kdr",
                Email = "kadir@gmail.com",
                DateOfBirth =  new DateTime(1998, 10, 24),
                Password = "kadir123"
            };


            GamerManager gamerManager = new GamerManager(new DataBase(new EdevletData()));
            gamerManager.Add(newgamer);
            Console.WriteLine("Gamer List:");
            foreach (var item in gamerManager.GetAll())
            {
                Console.WriteLine(" Name: {0} \n Surname:{1}\n UserName: {2} \n TcNo:{3}\n" +
                    " Password: {4} \n Birthday:{5}\n",
                    item.FirstName,item.LastName,item.UserName,item.TcNo,item.Password,item.DateOfBirth);
            }
            

            Console.ReadLine();






        }
    }
}
