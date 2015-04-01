using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Model.Order.Repositories
{
    interface IOrderRepository
    {
		void Insert(Order Order);

		void Delete(int id);

		Order Find(int id);

		List<Order> FindAll();
    }
}
