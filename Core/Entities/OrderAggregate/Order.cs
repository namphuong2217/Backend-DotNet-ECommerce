using System;
using System.Collections.Generic;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public Order()
        {
        }

        public Order(IReadOnlyList<OrderItem> orderItems, string buyerEmail,
        decimal total)
        {
            BuyerEmail = buyerEmail;
            OrderItems = orderItems;
            Total = total;
        }

        public string BuyerEmail { get; set; }
        // standard time
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        // Address owned by Order
        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public decimal Total { get; set; }

    }
}