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

        public void DestroyUser(User user);
        
        public User FindUser(int Id);

        public List<User> GetAllUsers();

        public void CreateRole(Role role);

        public void DestroyRole(Role role);

        public User FindUser(int Id);

        public List<Role> GetAllRoles();
    }
}
