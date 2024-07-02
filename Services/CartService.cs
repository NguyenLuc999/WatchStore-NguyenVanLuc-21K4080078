using System;
using System.Collections.Generic;
using System.Linq;
using WatchStore_NguyenVanLuc_21K4080078.Models;

namespace WatchStore_NguyenVanLuc_21K4080078.Services
{
    public class CartService
    {
        private List<Product> cart = new List<Product>();
        private readonly OrderService _orderService;

        public CartService(OrderService orderService)
        {
            _orderService = orderService;
        }

        public void AddToCart(Product product)
        {
            cart.Add(product);
        }

        public List<Product> GetCartItems()
        {
            return cart;
        }

        public int GetTotalItems()
        {
            return cart.Count;
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in cart)
            {
                total += item.Price;
            }
            return total;
        }

        public void ClearCart()
        {
            cart.Clear();
        }

        public void RemoveFromCart(Product product)
        {
            var itemToRemove = cart.FirstOrDefault(p => p.Id == product.Id);
            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
            }
        }

        public Order Checkout(string customerName, string address, string phoneNumber, string email)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CustomerName = customerName,
                Address = address,
                PhoneNumber = phoneNumber,
                Email = email,
                Products = new List<Product>(cart),
                Total = GetTotalPrice(),
                Date = DateTime.Now
            };
            _orderService.AddOrder(order);
            ClearCart();
            return order;
        }
    }
}
