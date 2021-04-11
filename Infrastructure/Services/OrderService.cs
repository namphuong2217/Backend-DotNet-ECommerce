using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Core.Specifications;

namespace Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        // Basket Repository is managed by Redis
        private readonly IBasketRepository _basketRepo;
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IBasketRepository basketRepo, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _basketRepo = basketRepo;
        }



        public async Task<Order> CreateOrderAsync(string buyerEmail, string basketId)
        {
            // 1 get basket from the repo
            var basket = await _basketRepo.GetBasketAsync(basketId);
            // 2 get items from product repo
            var items = new List<OrderItem>();
            foreach (var item in basket.Items)
            {
                var productItem = await _unitOfWork.Repository<Product>().GetByIdAsync(item.Id);
                var itemOrdered = new ProductItemOrdered(productItem.Id, productItem.Name, productItem.PictureUrl);
                // seperate product Price because we need to retrieve it from databas for validation
                var orderItem = new OrderItem(itemOrdered, productItem.Price, item.Quantity);
                items.Add(orderItem);
            }
            // 4 calculate total
            var total = items.Sum(item => item.Price * item.Quantity);

            // 5 create order 
            var order = new Order(items, buyerEmail, total);
            // UnitOfWork Add new Order 
            _unitOfWork.Repository<Order>().Add(order);

            // 6 TODO save to db UnitOfWork
            var result = await _unitOfWork.Complete();

            if (result <= 0) return null; // and let the controller response Error

            // delete basket as order is completed
            await _basketRepo.DeleteBasketAsync(basketId);

            // 7 return order
            return order;

        }
        public async Task<Order> GetOrderByIdAsync(int id, string buyerEmail)
        {
            var spec = new OrdersWithItemsAndOrderingSpecification(id, buyerEmail);

            return await _unitOfWork.Repository<Order>().GetEntityWithSpec(spec);
        }

        public async Task<IReadOnlyList<Order>> GetOrdersForUserAsync(string buyerEmail)
        {
            var spec = new OrdersWithItemsAndOrderingSpecification(buyerEmail);

            return await _unitOfWork.Repository<Order>().ListAsync(spec);
        }
    }
}