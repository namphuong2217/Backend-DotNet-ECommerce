using Core.Entities.OrderAggregate;

namespace API.Dtos
{
    // flat 1 OrderItem and shape data
    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}