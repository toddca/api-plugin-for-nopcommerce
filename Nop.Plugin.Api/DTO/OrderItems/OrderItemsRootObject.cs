// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="OrderItemsRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.OrderItems
{
    public class OrderItemsRootObject : ISerializableObject
    {
        public OrderItemsRootObject()
        {
            OrderItems = new List<OrderItemDto>();
        }

        [JsonProperty("order_items")]
        public IList<OrderItemDto> OrderItems { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "order_items";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(OrderItemDto);
        }
    }
}
