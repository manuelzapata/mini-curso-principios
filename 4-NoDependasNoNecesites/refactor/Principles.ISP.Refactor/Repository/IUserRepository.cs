using Principles.ISP.Refactor.Model;
using System.Collections.Generic;

namespace Principles.ISP.Refactor.Repository
{
    interface IUserRepository
    {

        void CreateUser(User user);

        List<User> ListUsers();

        void DeleteUser(User user);

    }
}
