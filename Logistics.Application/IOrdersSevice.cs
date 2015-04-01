using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Order;


namespace Logistics.Application
{
    interface IOrdersSevice
    {

        public void CreateOrder(Order order);

        public void AlterOrder(Order order);

        public void DestroyOrder(Order order);

        public List<Order> GetAllOrders();
    }
}
