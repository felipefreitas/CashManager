using CashManager.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManager.APPLICATION.Services.Interfaces
{
    interface IUserEngine
    {
        User CreateUser(string identifier, string password, string name, UserType userType = UserType.Cashier);
        User RemoveUser(User user);
        User ChangePassword(User user, string passwordNew);
        User LockUser(User user);
        User UnlockUser(User user);
    }
}
