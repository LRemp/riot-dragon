namespace backend.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? ImageName { get; set; }
        public int Price { get; set; }
    }
}
