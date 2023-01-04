using backend.Models;

namespace backend.Services
{
    public interface IMetadataItemService
    {
        void FetchItems();
        Item FetchItem(int id);
        void RegisterItem(int Id, string Name, string Description, string Type, string ImageName, int Price);
    }
    public class ItemsMetadataService : IMetadataItemService
    {
        private List<Item> _items;
        public ItemsMetadataService()
        {
            _items = new List<Item>();
        }
        public void FetchItems() 
        { 

        }
        public Item FetchItem(int id)
        {
            foreach(var item in _items)
                if(item.Id == id)
                    return item;
            return null;
        }
        public void RegisterItem(int Id, string Name, string Description, string Type, string ImageName, int Price) 
        {
            if (this.FetchItem(Id) != null) return;
            _items.Add(new Item
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Type = Type,
                ImageName = ImageName,
                Price = Price
            });
        }
    }
}
