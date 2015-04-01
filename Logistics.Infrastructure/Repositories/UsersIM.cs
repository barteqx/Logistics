using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistics.Domain.Model.User;

using Logistics.Domain.Model.User.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class UsersIM : IUserRepository
    {
        private List<User> users;
        private List<Role> roles;

        public UsersIM()
        {
            InitializeWithExampleData();
        }

        public void InitializeWithExampleData()
        {
            roles = new List<Role>
            {
                new Role {Id = 100, RoleName = "Administrator", CanCreateAlterDeleteItems = true, CanCreateAlterDeleteUsers = true,
                    CanCreateAlterDeleteRoles = true, CanCreateAlterDeleteOrders = true, CanSendOrders = true},
                new Role {Id = 101, RoleName = "Manager", CanCreateAlterDeleteItems = true, CanCreateAlterDeleteUsers = false,
                    CanCreateAlterDeleteRoles = false, CanCreateAlterDeleteOrders = true, CanSendOrders = true},
                new Role {Id = 101, RoleName = "Manager", CanCreateAlterDeleteItems = false, CanCreateAlterDeleteUsers = false,
                    CanCreateAlterDeleteRoles = false, CanCreateAlterDeleteOrders = false, CanSendOrders = true}
            };

            users = new List<User>
            {
                new User {Id = 1, Login = "admin", Email = "admin@examplestore.com", Name = "Administrator", Password = "aaaa123",
                    Role = roles[0]},
                new User {Id = 2, Login = "manager", Email = "manager@examplestore.com", Name = "Manager", Password = "bbb123",
                    Role = roles[1]},
                new User {Id = 3, Login = "worker1", Email = "worker1@examplestore.com", Name = "Worker 1", Password = "bbb123",
                    Role = roles[2]}
            };
        }



    }
}
