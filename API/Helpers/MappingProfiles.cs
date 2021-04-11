using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.BrandName))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.TypeName))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());

            CreateMap<CustomerBasketDto, CustomerBasket>();

            CreateMap<BasketItemDto, BasketItem>();

            CreateMap<Order, OrderToReturnDto>()
                .ForMember(d => d.DirectAccessToOrdersUrl, o => o.MapFrom<CarConfigurationUrlResolver>());
            
            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(d => d.ProductId, o => o.MapFrom(s => s.ItemOrdered.ProductItemId))
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.ItemOrdered.ProductName))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => s.ItemOrdered.PictureUrl))
                // resolve url  "pictureUrl": "images/products/boot-redis1.png",
                .ForMember(d => d.PictureUrl, o => o.MapFrom<OrderItemUrlResolver>());

            // flat the orderItems": [
            // from this
            // {
            //     "itemOrdered": {
            //         "productItemId": 4,
            //         "productName": "Redis Red Boots",
            //         "pictureUrl": "images/products/boot-redis1.png"
            //     },
            //     "price": 250,
            //     "quantity": 10,
            //     "id": 1
            // }
            // to this
            //      "orderItems": [
            //     {
            //         "productId": 0,
            //         "productName": null,
            //         "pictureUrl": null,
            //         "price": 250,
            //         "quantity": 10
            //     }

        }
    }
}