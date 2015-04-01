using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Model.Item.Repositories
{
    interface IItemRepository
    {
        void Insert(Item item);

        void Delete(int id);

        Item Find(int id);

        List<Item> FindAll();
    }
}