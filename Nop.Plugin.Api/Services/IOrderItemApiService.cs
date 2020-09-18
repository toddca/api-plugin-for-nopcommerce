// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="IOrderItemApiService.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
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
