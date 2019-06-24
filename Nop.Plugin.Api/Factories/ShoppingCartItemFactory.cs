// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="ShoppingCartItemFactory.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using Nop.Core.Domain.Orders;

namespace Nop.Plugin.Api.Factories
{
    public class ShoppingCartItemFactory : IFactory<ShoppingCartItem>
    {
        public ShoppingCartItem Initialize()
        {
            var newShoppingCartItem = new ShoppingCartItem();

            newShoppingCartItem.CreatedOnUtc = DateTime.UtcNow;
            newShoppingCartItem.UpdatedOnUtc = DateTime.UtcNow;

            return newShoppingCartItem;
        }
    }
}
