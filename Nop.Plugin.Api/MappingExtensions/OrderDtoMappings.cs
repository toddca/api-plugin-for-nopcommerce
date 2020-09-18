﻿// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="OrderDtoMappings.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Orders;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.Orders;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class OrderDtoMappings
    {
        public static OrderDto ToDto(this Order order)
        {
            return order.MapTo<Order, OrderDto>();
        }
    }
}
