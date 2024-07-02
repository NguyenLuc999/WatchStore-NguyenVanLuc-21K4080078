namespace WatchStore_NguyenVanLuc_21K4080078.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public string Category { get; set; } // Thêm thuộc tính Category
    }
}
