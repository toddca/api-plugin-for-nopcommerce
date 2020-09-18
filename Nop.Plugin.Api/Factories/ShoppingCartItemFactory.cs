// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ShoppingCartItemFactory.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
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
