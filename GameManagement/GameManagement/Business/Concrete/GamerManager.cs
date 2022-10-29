using GameManagement.Business.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _gamerValidationService;
    
        public GamerManager(IUserValidationService userValidationService)
        {
            _gamerValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if(_gamerValidationService.CheckUser(gamer))
            {
                Console.WriteLine("user added");
            }
            else
            {
                Console.WriteLine("Don't added");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("User Deleted ");
        }

        public void Update(Gamer gamer)
        {
            if (true)
            {
                Console.WriteLine("User added!");
            }
            else
            {
                throw new Exception("Not a valid person!!");
            }
        }
    }
}
