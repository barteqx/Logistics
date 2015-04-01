using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Item;

namespace Logistics.Domain.Model.Order
{
    class OrderRecord
    {
        public int Id { get; set; }

        public Item.Item OrderItem { get; sets; }

        public int Quantity { get; set; }
    }
}
