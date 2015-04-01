﻿using System;
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
                    CanCreateAlterDeleteRoles = true, CanCreateAlterDeleteUsers = true, CanSendUsers = true},
                new Role {Id = 101, RoleName = "Manager", CanCreateAlterDeleteItems = true, CanCreateAlterDeleteUsers = false,
                    CanCreateAlterDeleteRoles = false, CanCreateAlterDeleteUsers = true, CanSendUsers = true},
                new Role {Id = 101, RoleName = "Manager", CanCreateAlterDeleteItems = false, CanCreateAlterDeleteUsers = false,
                    CanCreateAlterDeleteRoles = false, CanCreateAlterDeleteUsers = false, CanSendUsers = true}
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

		public void InsertUser(User User)
		{
			users.Add(User);
		}

		public void DeleteUser(int Id)
		{
			foreach (var delivery in users)
			{
				if (delivery.Id == Id)
				{
					users.Remove(delivery);
					return;
				}
			}
		}

		public User FindUser (int Id)
		{
			foreach (var delivery in users)
				if (delivery.Id == Id)
					return delivery;
			return null;
		}

		public List<User> FindAllUsers()
		{
			return users;
		}

		public void InsertRole(Order Order)
		{
			ordersList.Add(Order);
		}

		public void DeleteRole(int Id)
		{
			foreach (var delivery in ordersList)
			{
				if (delivery.Id == Id)
				{
					ordersList.Remove(delivery);
					return;
				}
			}
		}

		public Order FindRole (int Id)
		{
			foreach (var delivery in ordersList)
				if (delivery.Id == Id)
					return delivery;
			return null;
		}

		public List<Order> FindAllRoles()
		{
			return ordersList;
		}

    }
}
