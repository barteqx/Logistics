using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Domain.Model.Item.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    class ItemsIM : IItemRepository
    {
		public List<Item> itemsList;

		public ItemsIM()
		{
			itemsList = new List<Item>
			{
				new Item { Id = 1, From = "Apple", ItemItems = new List<ItemRecord>{
						new ItemRecord { Id = 1, OrderItemId = 2, Quantity = 3}
					}, Accepted = false, Date = DateTime.Now }

			};
		}

		public void Insert(Item Item)
		{
			itemsList.Add(Item);
		}

		public void Delete(int Id)
		{
			foreach (var delivery in itemsList)
			{
				if (delivery.Id == Id)
				{
					itemsList.Remove(delivery);
					return;
				}
			}
		}

		public Item Find (int Id)
		{
			foreach (var delivery in itemsList)
				if (delivery.Id == Id)
					return delivery;
			return null;
		}

		public List<Item> FindAll()
		{
			return itemsList;
		}
    }
}
