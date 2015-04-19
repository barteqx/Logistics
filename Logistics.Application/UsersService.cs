using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Infrastructure.Repositories;
using Logistics.Domain.Model.User.Repositories;
using Logistics.Domain.Model.User;

namespace Logistics.Application
{
    public class UsersService : IUserService
    {
        private IUserRepository userRepository;


        public UsersService()
        {
            userRepository = new UsersIM();
        }

        public UsersService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IList<Domain.Model.User.User> GetAllUsers()
        {
            return userRepository.FindAllUsers();
        }

        public void CreateUser(Domain.Model.User.User p)
        {
            userRepository.InsertUser(p);
        }

        public User FindUser(int Id)
        {
            return userRepository.FindUser(Id);
        }

        public void DestroyUser(int Id)
        {
            userRepository.DeleteUser(Id);
        }
        public IList<Domain.Model.User.Role> GetAllRoles()
        {
            return userRepository.FindAllRoles();
        }

        public void CreateNewRole(Domain.Model.User.Role r)
        {
            userRepository.InsertUser(r);
        }

        public User FindRole(int Id)
        {
            return userRepository.FindRole(Id);
        }

        public void DestroyRole(int Id)
        {
            userRepository.DeleteRole(Id);
        }
    }
}
