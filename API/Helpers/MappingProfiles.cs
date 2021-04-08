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
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>())
                ;
            CreateMap<Core.Entities.Identity.Address, AddressDto>().ReverseMap();
            CreateMap<CustomerBasketDto, CustomerBasket>();
            CreateMap<BasketItemDto, BasketItem>();

            // order API Section 18
            CreateMap<AddressDto, Core.Entities.OrderAggregate.Address>();
            // flat the orderItems": [
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
            CreateMap<Order, OrderToReturnDto>()
            //      shaping data and make mapper smarter
            //      "deliveryMethod": "Core.Entities.OrderAggregate.DeliveryMethod",
            //      "shippingPrice": 0,
            //      "orderItems": [
            //     {
            //         "productId": 0,
            //         "productName": null,
            //         "pictureUrl": null,
            //         "price": 250,
            //         "quantity": 10
            //     }
            .ForMember(d => d.DeliveryMethod, o => o.MapFrom(s => s.DeliveryMethod.ShortName))
            .ForMember(d => d.ShippingPrice, o => o.MapFrom(s => s.DeliveryMethod.Price));
            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(d => d.ProductId, o => o.MapFrom(s => s.ItemOrdered.ProductItemId))
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.ItemOrdered.ProductName))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => s.ItemOrdered.PictureUrl))
                // resolve url  "pictureUrl": "images/products/boot-redis1.png",
                .ForMember(d => d.PictureUrl, o => o.MapFrom<OrderItemUrlResolver>());
            ;

        }
    }
}