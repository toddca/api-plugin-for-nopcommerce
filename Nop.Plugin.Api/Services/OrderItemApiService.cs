// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="OrderItemApiService.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Nop.Core.Domain.Orders;
using Nop.Plugin.Api.DataStructures;
using Nop.Services.Orders;

namespace Nop.Plugin.Api.Services
{
    public class OrderItemApiService : IOrderItemApiService
    {
        private readonly IOrderService _orderService;

        public OrderItemApiService(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IList<OrderItem> GetOrderItemsForOrder(Order order, int limit, int page, int sinceId)
        {
            var orderItems = _orderService.GetOrderItems(order.Id).AsQueryable();

            return new ApiList<OrderItem>(orderItems, page - 1, limit);
        }

        public int GetOrderItemsCount(Order order)
        {
            return _orderService.GetOrderItems(order.Id).Count;
        }
    }
}
