using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.User;

namespace Logistics.Domain.Model.Order
{
    public class OrderStatus
    {
        public enum OrderState
        {
            AwaitngAcceptance,
            Accepted,
            BeingCompleted,
            PreparedToBeSent,
            DeliveryOngoing,
            Delivered,
            Returned,
            Canceled,
            Other
        }

        public int Id { get; set; }

        public OrderState State { get; set; }

        public string Comment { get; set; }

        public User.User ModifiedBy { get; set; }
    }
}
