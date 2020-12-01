using AutoMapper;
using GraphQL_EF5Core_API.DomainModels;
using GraphQL_EF5Core_API.Resources;

namespace GraphQL_EF5Core_API.ApplicationLayer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            
            CreateMap<OrderLine, OrderLineDto>();
            CreateMap<OrderLineDto, OrderLine>();
        }
    }
}