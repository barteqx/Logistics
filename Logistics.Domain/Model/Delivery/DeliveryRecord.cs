using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Item;

namespace Logistics.Domain.Model.Delivery
{
    public class DeliveryRecord
    {
        public int Id { get; set; }

        public int OrderItemId { get; set; }

        public int Quantity { get; set; }
    }
}
