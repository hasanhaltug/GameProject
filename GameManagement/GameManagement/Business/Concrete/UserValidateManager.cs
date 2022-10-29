using GameManagement.Business.Abstract;
using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Concrete
{
    public class UserValidateManager : IUserValidationService
    {
         
            
        public bool CheckUser(Gamer gamer)
        {
            return true;
        }
    }

}
