using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Model.Item
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AvailableQuantity { get; set; }

        public Logistics.Domain.Model.User.User AddedBy { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
