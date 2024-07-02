using WatchStore_NguyenVanLuc_21K4080078.Models;
using System.Collections.Generic;
using System.Linq;
using WatchStore_NguyenVanLuc_21K4080078.Pages;

namespace WatchStore_NguyenVanLuc_21K4080078.Services
{
    public class ProductService
    {

        private List<Product> Products = new List<Product>
        { new Product { Id = 1, Name = "Rolex Daytona", Description = "Một chiếc đồng hồ lặn huyền thoại nổi tiếng về độ bền và hiệu suất", Price = 25000, ImageUrl = "images/Q1.png" },
            new Product { Id = 2, Name = "Rolex GMT-Master II", Description = " Thiết kế thanh lịch, sang trọng hơn so với Big Bang. Vẫn giữ nét độc đáo của Hublot với sự kết hợp vật liệu sáng tạo", Price = 28000, ImageUrl = "images/Q2.png" },
            new Product { Id = 3, Name = "Rolex Datejust", Description = " Lấy cảm hứng từ thể thao với thiết kế năng động, trẻ trung. Sử dụng nhiều dây đeo cao su tạo cảm giác thoải mái khi đeo", Price = 30000, ImageUrl = "images/Q3.png" },
            new Product { Id = 4, Name = "Rolex Oyster Perpetual", Description = " Thiết kế hầm hố, mạnh mẽ dành cho những người đàn ông cá tính.", Price = 32000, ImageUrl = "images/Q4.png" },


             new Product { Id = 5, Name = "Rolex Yacht-Master", Description = " Dòng đồng hồ dành cho du thuyền với thiết kế sang trọng và thanh lịch. Yacht-Master được trang bị viền bezel xoay hai chiều 60 phút, có khả năng chống nước cao lên đến 200 mét và có nhiều phiên bản mặt số và dây đeo khác nhau..", Price = 57000 , ImageUrl = "images/11.png" },
              new Product { Id = 6, Name = "Rolex Sky-Dweller", Description = " Dòng đồng hồ dành cho những người thường xuyên đi du lịch với chức năng hiển thị nhiều múi giờ phức tạp. Sky-Dweller được trang bị bộ máy chronograph hoàn toàn mới và có nhiều phiên bản mặt số và dây đeo khác nhau.", Price = 17000, ImageUrl = "images/22.png" },
               new Product { Id = 7, Name = "Rolex Explorer", Description = " Dòng đồng hồ dành cho những nhà thám hiểm với thiết kế mạnh mẽ và bền bỉ. Explorer được trang bị khả năng chống nước cao lên đến 200 mét, có mặt số đơn giản dễ đọc và có nhiều phiên bản mặt số và dây đeo khác nhau.", Price = 27000, ImageUrl = "images/33.png" },
                new Product { Id = 8, Name = "Rolex Air-King", Description = " Dòng đồng hồ phi công với thiết kế đơn giản và thanh lịch. Air-King được trang bị bộ máy chronograph cơ bản và có giá thành rẻ hơn so với các dòng đồng hồ Rolex khác.", Price = 31000, ImageUrl = "images/44.png" },
                 new Product { Id = 9, Name = "Rolex Milgauss", Description = " Dòng đồng hồ dành cho các nhà khoa học với khả năng chống từ trường cao. Milgauss được trang bị bộ máy chống từ trường lên đến 1.000 Gauss và có thiết kế độc đáo với kim giây màu cam..", Price = 40000, ImageUrl = "images/55.png" },
                




             new Product { Id = 10, Name = "Hublot MP-05 LaFerrari", Description = "Thiết kế độc đáo lấy cảm hứng từ siêu xe Ferrari LaFerrari. Sử dụng bộ máy Tourbillon phức tạp", Price = 25000, ImageUrl = "images/Q5.png" },
            new Product { Id = 11, Name = "Hublot Big Bang Unico", Description = "Bộ máy chronograph tự động được phát triển độc quyền bởi Hublot.", Price = 28100, ImageUrl = "images/Q6.png" },
            new Product { Id = 12, Name = "Hublot Classic Fusion Aerofusion", Description = "Thiết kế hiện đại, thanh lịch với bộ khung xương lộ cơ. Sử dụng nhiều vật liệu cao cấp như vàng, titanium, gốm sứ.", Price = 30000, ImageUrl = "images/Q7.png" },
            new Product { Id = 13, Name = "Hublot Hublottique", Description = " Dòng đồng hồ dành cho phụ nữ với thiết kế tinh tế, sang trọng. Sử dụng nhiều kim cương và đá quý để trang trí", Price = 32000, ImageUrl = "images/Q8.png" },
             new Product { Id = 14, Name = "Hublot Techframe Ferrari", Description = "Thiết kế lấy cảm hứng từ khung xe Ferrari với cấu trúc phức tạp. Sử dụng nhiều vật liệu nhẹ như carbon fiber và titan.", Price = 25000, ImageUrl = "images/Q9.png" },
            new Product { Id = 15, Name = " Hublot Meca-10", Description = "Bộ máy cơ học tự lên dây với mô-men xoắn dự trữ lên đến 42 giờ. Thiết kế đơn giản, thanh lịch với mặt số lộ cơ", Price = 28000, ImageUrl = "images/Q10.png" },


             new Product { Id = 16, Name = "Citizen", Description = "Đồng hồ đôi Citizen có thiết kế sang trọng, tinh tế và sử dụng các vật liệu cao cấp như thép không gỉ, kính sapphire, kim loại mạ vàng hoặc mạ bạc. Các mẫu đồng hồ này thường có nhiều tính năng như chronograph, lịch vạn niên, và khả năng chống nước tốt.", Price = 15000, ImageUrl = "images/d1.jpg" },
            new Product { Id = 17, Name = "Tissot", Description = "Đồng hồ đôi Tissot có thiết kế đa dạng, từ cổ điển đến hiện đại, phù hợp với mọi phong cách. Các mẫu đồng hồ này thường sử dụng các vật liệu cao cấp như thép không gỉ, kính sapphire, kim loại mạ vàng hoặc mạ bạc, và có nhiều tính năng như chronograph, lịch vạn niên, và khả năng chống nước tốt..", Price = 25000, ImageUrl = "images/D2.jpg" },
            new Product { Id = 18, Name = "Longines", Description = " Đồng hồ đôi Longines có thiết kế đa dạng, từ cổ điển đến hiện đại, phù hợp với mọi phong cách. Các mẫu đồng hồ này thường sử dụng các vật liệu cao cấp như thép không gỉ, kính sapphire, kim loại mạ vàng hoặc mạ bạc, và có nhiều tính năng như chronograph, lịch vạn niên, và khả năng chống nước tốt.", Price = 32000, ImageUrl = "images/D3.jpg" },
             new Product { Id = 19, Name = "Seiko", Description = "Đồng hồ đôi Seiko có nhiều kiểu dáng và tính năng, phù hợp với nhiều phong cách. Bạn có thể tìm thấy đồng hồ đeo tay thạch anh và tự động, với dây đeo bằng kim loại hoặc da. Nhiều mẫu có khả năng chống nước và các tính năng khác như lịch ngày, chronograph và kim dạ quang.", Price = 22500, ImageUrl = "images/D4.jpg" },
            new Product { Id = 20, Name = " Orient", Description = " Đồng hồ đôi Orient có thiết kế cổ điển và thanh lịch, thường sử dụng vật liệu chất lượng như thép không gỉ và kính sapphire. Nhiều mẫu có chức năng tự động lên dây và khả năng chống nước.", Price = 28000, ImageUrl = "images/D5.jpg" },



        };

        public List<Product> GetProducts() => Products;

        public Product GetProductById(int id) => Products.FirstOrDefault(p => p.Id == id);




        public List<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return Products;
            }
            return Products.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) || p.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> FilterProducts(decimal minPrice, decimal maxPrice)
        {
            return Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }
        public void AddReview(int productId, Review review)
        {
            var product = GetProductById(productId);
            if (product != null)
            {
                product.Reviews.Add(review);
            }
        }

        public List<Product> GetTopFavoriteProducts(int count)
        {
            // Logic giả định để lấy các sản phẩm yêu thích
            return Products.Take(count).ToList();
        }
        public List<Product> GetCoupleWatches(int count)
        {
                return Products.Where(p => p.Category == "Couple").Take(count).ToList();
        }
        public List<Product> GetAllProducts()
        {
            // Lấy tất cả sản phẩm
            return Products;
        }
        public List<Product> GetProductsByCategory(string category)
        {
            return Products.Where(p => p.Category == category).ToList();
        }

    }
}

