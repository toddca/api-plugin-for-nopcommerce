// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="IOrderItemApiService.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using Nop.Core.Domain.Orders;

namespace Nop.Plugin.Api.Services
{
    public interface IOrderItemApiService
    {
        IList<OrderItem> GetOrderItemsForOrder(Order order, int limit, int page, int sinceId);
        int GetOrderItemsCount(Order order);
    }
}
