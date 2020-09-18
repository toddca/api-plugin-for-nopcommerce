// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="OrderFactory.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Payments;
using Nop.Core.Domain.Shipping;

namespace Nop.Plugin.Api.Factories
{
    public class OrderFactory : IFactory<Order>
    {
        public Order Initialize()
        {
            var order = new Order();

            order.CreatedOnUtc = DateTime.UtcNow;
            order.OrderGuid = new Guid();
            order.PaymentStatus = PaymentStatus.Pending;
            order.ShippingStatus = ShippingStatus.NotYetShipped;
            order.OrderStatus = OrderStatus.Pending;

            return order;
        }
    }
}
