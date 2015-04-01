using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Model.User.Repositories
{
    interface IUserRepository
    {
        void InsertUser(User User);

        void DeleteUser(int id);

        User FindUser(int id);

        List<User> FindAllUsers();

        void InsertRole(Role role);

        void DeleteRole(int id);

        User FindRole(int id);

        List<User> FindAllRoles();
    }
}
