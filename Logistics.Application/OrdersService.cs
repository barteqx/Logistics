using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Order.Repositories;
using Logistics.Infrastructure.Repositories;

namespace Logistics.Application
{
    class OrdersService : IOrdersSevice
    {
        private IOrderRepository orderRepository;

        public OrdersService()
        {
            orderRepository = new OrdersIM();
        }

        public OrdersService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IList<Domain.Model.Order.Order> GetAllOrders()
        {
            return orderRepository.FindAll();
        }

        public void CreateNewOrder(Domain.Model.Order.Order p)
        {
            orderRepository.Insert(p);
        }

		public Domain.Model.Order.Order FindOrder(int Id)
		{
			return orderRepository.Find (Id);
		}

		public void DeleteOrder(int Id)
		{
			orderRepository.Delete (Id);
		}
    }
    }
}
