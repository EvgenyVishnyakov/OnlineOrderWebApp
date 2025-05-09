﻿namespace OnlineOrder.Db.Models
{
    public class OrderProduct
    {
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public int ProductCount { get; set; }
    }
}
