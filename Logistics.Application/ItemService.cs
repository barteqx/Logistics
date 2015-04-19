using Logistics.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logistics.Infrastructure.Repositories;
using Logistics.Domain.Model.Item.Repositories;

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

        public void CreateItem(Domain.Model.Item.Item p)
        {
            itemRepository.Insert(p);
        }

        public Domain.Model.Item.Item FindItem(int Id)
        {
            return itemRepository.Find(Id);
        }

        public void DestroyItem(int Id)
        {
            itemRepository.Delete(Id);
        }
    }
}
