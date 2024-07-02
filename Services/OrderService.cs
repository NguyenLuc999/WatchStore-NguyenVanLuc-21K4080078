using System;
using System.Collections.Generic;
using System.Linq;
using WatchStore_NguyenVanLuc_21K4080078.Models;

namespace WatchStore_NguyenVanLuc_21K4080078.Services
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public Order GetOrderById(Guid id)
        {
            return orders.FirstOrDefault(o => o.Id == id);
        }
    }

    public class Order
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Product> Products { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}
