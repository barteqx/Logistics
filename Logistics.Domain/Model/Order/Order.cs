﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Model.Order
{
    class Order
    {

        public int Id { get; set; }

        public List<OrderRecord> OrderItems { get; set; }

        public List<OrderStatus> OrderHistory { get; set; }

        public string OrderId { get; set; }
    }
}
