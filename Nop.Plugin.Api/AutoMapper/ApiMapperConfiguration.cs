// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ApiMapperConfiguration.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutoMapper;
using JetBrains.Annotations;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Messages;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Stores;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.Mapper;
using Nop.Plugin.Api.Areas.Admin.Models;
using Nop.Plugin.Api.Domain;
using Nop.Plugin.Api.DTO;
using Nop.Plugin.Api.DTO.Categories;
using Nop.Plugin.Api.DTO.CustomerRoles;
using Nop.Plugin.Api.DTO.Customers;
using Nop.Plugin.Api.DTO.Languages;
using Nop.Plugin.Api.DTO.Manufacturers;
using Nop.Plugin.Api.DTO.NewsLetterSubscriptions;
using Nop.Plugin.Api.DTO.OrderItems;
using Nop.Plugin.Api.DTO.Orders;
using Nop.Plugin.Api.DTO.ProductAttributes;
using Nop.Plugin.Api.DTO.ProductCategoryMappings;
using Nop.Plugin.Api.DTO.ProductManufacturerMappings;
using Nop.Plugin.Api.DTO.Products;
using Nop.Plugin.Api.DTO.ShoppingCarts;
using Nop.Plugin.Api.DTO.SpecificationAttributes;
using Nop.Plugin.Api.DTO.Stores;
using Nop.Plugin.Api.MappingExtensions;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Services.Directory;
using Nop.Services.Orders;

namespace Nop.Plugin.Api.AutoMapper
{
    [UsedImplicitly]
    public class ApiMapperConfiguration : Profile, IOrderedMapperProfile
    {
        public ApiMapperConfiguration()
        {
            CreateMap<ApiSettings, ConfigurationModel>();
            CreateMap<ConfigurationModel, ApiSettings>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Store, StoreDto>();

            CreateMap<ProductCategory, ProductCategoryMappingDto>();

            CreateMap<ProductManufacturer, ProductManufacturerMappingsDto>();

            CreateMap<Language, LanguageDto>();

            CreateMap<CustomerRole, CustomerRoleDto>();

            CreateMap<Manufacturer, ManufacturerDto>();

            CreateAddressMap();
            CreateAddressDtoToEntityMap();
            CreateShoppingCartItemMap();

            CreateCustomerToDtoMap();
            CreateCustomerToOrderCustomerDTOMap();
            CreateCustomerDTOToOrderCustomerDTOMap();
            CreateCustomerForShoppingCartItemMapFromCustomer();

            CreateMap<OrderItem, OrderItemDto>();
            CreateOrderEntityToOrderDtoMap();

            CreateProductMap();

            CreateMap<ProductAttributeValue, ProductAttributeValueDto>();

            CreateMap<ProductAttribute, ProductAttributeDto>();

            CreateMap<ProductSpecificationAttribute, ProductSpecificationAttributeDto>();

            CreateMap<SpecificationAttribute, SpecificationAttributeDto>();
            CreateMap<SpecificationAttributeOption, SpecificationAttributeOptionDto>();

            CreateMap<NewsLetterSubscriptionDto, NewsLetterSubscription>();
            CreateMap<NewsLetterSubscription, NewsLetterSubscriptionDto>();
        }

        public int Order => 0;

        private IOrderService _orderService;
        private ICountryService _countryService;
        private IStateProvinceService _stateProvinceService;
        private ICustomerService _customerService;
        private IProductTagService _productTagService;
        private IShoppingCartService _shoppingCartService;
        private IProductService _productService;

        private IOrderService OrderService => _orderService ??= EngineContext.Current.Resolve<IOrderService>();
        private ICountryService CountryService => _countryService ??= EngineContext.Current.Resolve<ICountryService>();
        private IStateProvinceService StateProvinceService => _stateProvinceService ??= EngineContext.Current.Resolve<IStateProvinceService>();
        private ICustomerService CustomerService => _customerService ??= EngineContext.Current.Resolve<ICustomerService>();
        private IProductTagService ProductTagService => _productTagService ??= EngineContext.Current.Resolve<IProductTagService>();
        private IShoppingCartService ShoppingCartService => _shoppingCartService ??= EngineContext.Current.Resolve<IShoppingCartService>();
        private IProductService ProductService => _productService ??= EngineContext.Current.Resolve<IProductService>();

        private new static void CreateMap<TSource, TDestination>()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<TSource, TDestination>()
                                      .IgnoreAllNonExisting();
        }
        
        private void CreateOrderEntityToOrderDtoMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Order, OrderDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                                      .ForMember(x => x.OrderItems, y => y.MapFrom(src => OrderService.GetOrderItems(src.Id, null, null, 0).Select(x => x.ToDto())));
        }

        private void CreateAddressMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Address, AddressDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                                      .ForMember(x => x.CountryName,
                                                 y => y.MapFrom(src => CountryService.GetCountryById(src.Id).GetWithDefault(x => x, new Country()).Name))
                                      .ForMember(x => x.StateProvinceName,
                                                 y => y.MapFrom(src => StateProvinceService.GetStateProvinceById(src.StateProvinceId.GetValueOrDefault()).GetWithDefault(x => x, new StateProvince()).Name));
        }

        private void CreateAddressDtoToEntityMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<AddressDto, Address>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id));
        }

        private void CreateCustomerForShoppingCartItemMapFromCustomer()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression
                                      .CreateMap<Customer, CustomerForShoppingCartItemDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                                      .ForMember(x => x.BillingAddress,
                                                 y => y.MapFrom(src => CustomerService.GetCustomerBillingAddress(src).GetWithDefault(x => x, new Address()).ToDto()))
                                      .ForMember(x => x.ShippingAddress,
                                                 y => y.MapFrom(src => CustomerService.GetCustomerShippingAddress(src).GetWithDefault(x => x, new Address()).ToDto()))
                                      .ForMember(x => x.Addresses,
                                                 y => y.MapFrom(src => CustomerService.GetAddressesByCustomerId(src.Id).GetWithDefault(x => x, new List<Address>()).Select(address => address.ToDto())));
        }

        private void CreateCustomerToDtoMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Customer, CustomerDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                                      .ForMember(x => x.BillingAddress,
                                                 y => y.MapFrom(src => CustomerService.GetCustomerBillingAddress(src).GetWithDefault(x => x, new Address()).ToDto()))
                                      .ForMember(x => x.ShippingAddress,
                                                 y => y.MapFrom(src => CustomerService.GetCustomerShippingAddress(src).GetWithDefault(x => x, new Address()).ToDto()))
                                      .ForMember(x => x.Addresses,
                                                 y => y.MapFrom(src => CustomerService.GetAddressesByCustomerId(src.Id).GetWithDefault(x => x, new List<Address>()).Select(address => address.ToDto())))
                                      .ForMember(x => x.ShoppingCartItems,
                                                 y =>
                                                     y.MapFrom(
                                                               src => ShoppingCartService.GetShoppingCart(src, null, 0, null, null, null).GetWithDefault(x => x, new List<ShoppingCartItem>())
                                                                      .Select(item => item.ToDto())))
                                      .ForMember(x => x.RoleIds, y => y.MapFrom(src => CustomerService.GetCustomerRoles(src, false).Select(z => z.Id)));
        }

        private void CreateCustomerToOrderCustomerDTOMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Customer, OrderCustomerDto>()
                                      .IgnoreAllNonExisting();
        }

        private void CreateCustomerDTOToOrderCustomerDTOMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<CustomerDto, OrderCustomerDto>()
                                      .IgnoreAllNonExisting();
        }

        private void CreateShoppingCartItemMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<ShoppingCartItem, ShoppingCartItemDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.CustomerDto,
                                                 y => y.MapFrom(src =>
                                                                     CustomerService.GetCustomerById(src.CustomerId).GetWithDefault(x => x, new Customer()).ToCustomerForShoppingCartItemDto()))
                                      .ForMember(x => x.ProductDto,
                                                 y => y.MapFrom(src => ProductService.GetProductById(src.ProductId).GetWithDefault(x => x, new Product()).ToDto()));
        }

        private void CreateProductMap()
        {
            AutoMapperApiConfiguration.MapperConfigurationExpression.CreateMap<Product, ProductDto>()
                                      .IgnoreAllNonExisting()
                                      .ForMember(x => x.FullDescription, y => y.MapFrom(src => WebUtility.HtmlEncode(src.FullDescription)))
                                      .ForMember(x => x.Tags,
                                                 y => y.MapFrom(src => ProductTagService.GetAllProductTagsByProductId(src.Id).Select(x => x.Name)));
        }
    }
}
