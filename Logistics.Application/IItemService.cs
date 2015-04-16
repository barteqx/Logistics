using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Item;

namespace Logistics.Application
{
    interface IItemService
    {
        public Item GetItem(int id);

        public void CreateItem(Item item);

        public void AlterItem(Item item);

        public void DestroyItem(Item item);

        public List<Item> GetAllItems();
    }
}
