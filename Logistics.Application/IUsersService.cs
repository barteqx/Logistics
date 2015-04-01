using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.User;

namespace Logistics.Application
{
    interface IUsersService
    {
        public void CreateUser(User user);

        public void AlterUser(User user);

        public void DestroyUser(User user);

        public List<User> GetAllUsers();

        public void CreateRole(Role role);

        public void AlterRole(Role role);

        public void DestroyRole(Role role);

        public List<Role> GetAllRoles();
    }
}
