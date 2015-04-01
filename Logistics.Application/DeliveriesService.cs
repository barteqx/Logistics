using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Delivery.Repositories;
using Logistics.Infrastructure.Repositories;

namespace Logistics.Application
{
    class DeliveriesService : IDeliveriesService
    {
        private IDeliveryRepository deliveryRepository;


        public DeliveriesService()
        {
            deliveryRepository = new DeliveriesIM();
        }

        public DeliveriesService(IDeliveryRepository deliveryRepository)
        {
            this.deliveryRepository = deliveryRepository;
        }

        public IList<Domain.Model.Delivery.Delivery> GetAllDeliveries()
        {
            return deliveryRepository.FindAll();
        }

        public void CreateNewDelivery(Domain.Model.Delivery.Delivery p)
        {
            deliveryRepository.Insert(p);
        }

		public Delivery FindDelivery(int Id)
		{
			deliveryRepository.Find (Id);
		}

		public void DeleteDelivery(int Id)
		{
			deliveryRepository.Delete (Id);
		}
    }
}
