using Logistics.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Application
{
    class ItemService : IItemService
    {
		public void CreateItem(Item order);

		public void AlterItem(Item order);

		public void DestroyItem(Item order);

		public List<Item> GetAllItems();
    }
}
