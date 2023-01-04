namespace backend.Models
{
    public class ItemsCollection
    {
        private List<Item> Items;
        public ItemsCollection()
        {
            this.Items = new List<Item>();
        }
        public ItemsCollection(List<Item> Items)
        {
            this.Items = new List<Item>();
            foreach (Item item in Items)
                this.Items.Add(item);
        }
        public void SaveItems(List<Item> Items)
        {
            foreach(Item item in Items)
                this.Items.Add(item);
        }
        public Item? GetItem(int ItemId)
        {
            for(int i = 0; i < Items.Count; i++)
                if (Items[i].Id == ItemId)
                    return Items[i];
            return null;
        }
    }
}
