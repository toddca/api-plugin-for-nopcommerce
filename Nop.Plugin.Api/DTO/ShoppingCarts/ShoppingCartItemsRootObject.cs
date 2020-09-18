// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ShoppingCartItemsRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.ShoppingCarts
{
    public class ShoppingCartItemsRootObject : ISerializableObject
    {
        public ShoppingCartItemsRootObject()
        {
            ShoppingCartItems = new List<ShoppingCartItemDto>();
        }

        [JsonProperty("shopping_carts")]
        public IList<ShoppingCartItemDto> ShoppingCartItems { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "shopping_carts";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(ShoppingCartItemDto);
        }
    }
}
