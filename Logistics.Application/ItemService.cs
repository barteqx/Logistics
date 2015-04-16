using Logistics.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Infrastructure.Repositories;

namespace Logistics.Application
{
    public class ItemsService : IItemService
    {
        private IItemRepository itemRepository;


        public ItemsService()
        {
            itemRepository = new ItemsIM();
        }

        public ItemsService(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public IList<Domain.Model.Item.Item> GetAllItems()
        {
            return itemRepository.FindAll();
        }

        public void CreateNewItem(Domain.Model.Item.Item p)
        {
            itemRepository.Insert(p);
        }

        public Item FindItem(int Id)
        {
            itemRepository.Find(Id);
        }

        public void DeleteItem(int Id)
        {
            itemRepository.Delete(Id);
        }
    }
}
