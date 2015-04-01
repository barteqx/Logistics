using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Order.Repositories;
using Logistics.Domain.Model.Order;

namespace Logistics.Infrastructure.Repositories
{
    class OrdersIM : IOrderRepository
    {
		public List<Order> ordersList;

		public OrdersIM()
		{
			ordersList = new List<Order>
			{
				new Order 
                { 
                    Id = 1, OrderItems = new List<OrderRecord> {
                        new OrderRecord { Id = 1, OrderItem = 1, Quantity = 1 }
                    }, OrderHistory = new List<OrderStatus> 
                    {
                        new OrderStatus { Id = 1, Comment = "", State = OrderStatus.OrderState.Accepted, ModifiedBy = 101}
                    }
                }
			};
		}

		public void Insert(Order Order)
		{
			ordersList.Add(Order);
		}

		public void Delete(int Id)
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

		public Order Find (int Id)
		{
			foreach (var delivery in ordersList)
				if (delivery.Id == Id)
					return delivery;
			return null;
		}

		public List<Order> FindAll()
		{
			return ordersList;
		}
    }
}
