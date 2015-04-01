using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Delivery;

namespace Logistics.Application
{
    interface IDeliveriesService
    {
        IList<Delivery> GetAllDeliveries();

        void CreateNewDelivery(Delivery delivery);

		Delivery FindDelivery (int Id);

		void DeleteDelivery (int Id);
    }
}
