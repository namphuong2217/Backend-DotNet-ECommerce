using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class CarConfigurationUrlResolver
    : IValueResolver<Order, OrderToReturnDto, string>
    {
        private readonly IConfiguration _config;
        private string pathToCarConfiguration = "api/orders";
        public CarConfigurationUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Order source, OrderToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.BuyerEmail))
            {
                return _config["ApiUrl"] + pathToCarConfiguration;
            }

            return null;
        }
    }
}