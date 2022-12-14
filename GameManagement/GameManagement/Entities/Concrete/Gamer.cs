using GameManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entities.Concrete
{
    public class Gamer : IEntity
    {
        public string TcNo { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
