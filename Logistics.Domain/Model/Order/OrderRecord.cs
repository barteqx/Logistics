using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Item;

namespace Logistics.Domain.Model.Order
{
    public class OrderRecord
    {
        public int Id { get; set; }

        public Item.Item OrderItem { get; set; }

        public int Quantity { get; set; }
    }
}
