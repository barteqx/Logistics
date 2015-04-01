using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Logistics.Domain.Model.Delivery.Repositories;
using Logistics.Domain.Model.Delivery;


namespace Logistics.Infrastructure.Repositories
{
    public class DeliveriesIM : IDeliveryRepository
    {

        public List<Delivery> deliveriesList;

        public DeliveriesIM()
        {
            deliveriesList = new List<Delivery>
            {
                new Delivery { Id = 1, From = "Apple", DeliveryItems = new List<DeliveryRecord>{
                    new DeliveryRecord { Id = 1, OrderItemId = 2, Quantity = 3}
                }, Accepted = false, Date = DateTime.Now }

            };
        }

        public void Insert(Delivery Delivery)
        {
            deliveriesList.Add(Delivery);
        }

        public void Delete(int Id)
        {
            foreach (var delivery in deliveriesList)
            {
                if (delivery.Id == Id)
                {
                    deliveriesList.Remove(delivery);
                    return;
                }
            }
        }

        public Delivery Find (int Id)
        {
            foreach (var delivery in deliveriesList)
                if (delivery.Id == Id)
                    return delivery;
            return null;
        }

        public List<Delivery> FindAll()
        {
            return deliveriesList;
        }
    }
}
