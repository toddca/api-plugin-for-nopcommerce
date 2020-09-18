// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="OrdersRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Orders
{
    public class OrdersRootObject : ISerializableObject
    {
        public OrdersRootObject()
        {
            Orders = new List<OrderDto>();
        }

        [JsonProperty("orders")]
        public IList<OrderDto> Orders { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "orders";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(OrderDto);
        }
    }
}
