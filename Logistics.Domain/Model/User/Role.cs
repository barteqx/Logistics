using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Model.User
{
    public class Role
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        public bool CanCreateAlterDeleteItems { get; set; }

        public bool CanCreateAlterDeleteUsers { get; set; }

        public bool CanCreateAlterDeleteRoles { get; set; }

        public bool CanCreateAlterDeleteOrders { get; set; }

        public bool CanSendOrders { get; set; }
    }
}
