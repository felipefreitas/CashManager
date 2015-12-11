using CashManager.APPLICATION.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashManager.DOMAIN.Entities;

namespace CashManager.APPLICATION.Services.Engines
{
    class UserEngine : IUserEngine
    {
        public User ChangePassword(User user, string password)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(string identifier, string password, string name, UserType userType = UserType.Cashier)
        {
            if (string.IsNullOrEmpty(identifier) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException();
            }

            var user = new User()
            {
                Identifier = identifier,
                Password = password,
                UserType = userType
            };

            throw new NotImplementedException();
        }

        public User LockUser(User user)
        {
            throw new NotImplementedException();
        }

        public User RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UnlockUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
