using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.InharitanceApp
{
    public class UserService : BaseServices
    {
        public void Login()
        {
            ValidateInteger(1);
        }
        public void Register ()
        {
            ValidateString("");
        }
    }
}
