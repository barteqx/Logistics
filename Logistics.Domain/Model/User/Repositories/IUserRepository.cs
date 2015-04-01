using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Model.User.Repositories
{
    interface IUserRepository
    {
        void Insert(User User);

        void Delete(int id);

        User Find(int id);

        List<User> FindAll();

        void InsertRole(Role role);

        void DeleteRole(int id);

        User FindRole(int id);

        List<User> FindAllRoles();
    }
}
