using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Delivery;

namespace Logistics.Domain.Model.Delivery.Repositories
{
    interface IDeliveryRepository
    {
        void Insert(Delivery Delivery);

        void Delete(int id);

        Delivery Find(int id);

        List<Delivery> FindAll();
    }
}
