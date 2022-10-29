using GameManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Business.Abstract
{
    public interface IUserValidationService
    {
        bool CheckUser(Gamer gamer);
       
    }
}
