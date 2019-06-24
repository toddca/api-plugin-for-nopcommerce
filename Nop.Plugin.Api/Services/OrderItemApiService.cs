// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="OrderItemApiService.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Nop.Core.Domain.Orders;
using Nop.Plugin.Api.DataStructures;

namespace Nop.Plugin.Api.Services
{
    public class OrderItemApiService : IOrderItemApiService
    {
        public IList<OrderItem> GetOrderItemsForOrder(Order order, int limit, int page, int sinceId)
        {
            var orderItems = order.OrderItems.AsQueryable();

            return new ApiList<OrderItem>(orderItems, page - 1, limit);
        }

        public int GetOrderItemsCount(Order order)
        {
            var orderItemsCount = order.OrderItems.Count();

            return orderItemsCount;
        }
    }
}
