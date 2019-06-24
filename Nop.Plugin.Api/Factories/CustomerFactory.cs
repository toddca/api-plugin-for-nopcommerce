// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="CustomerFactory.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using Nop.Core.Domain.Customers;

namespace Nop.Plugin.Api.Factories
{
    public class CustomerFactory : IFactory<Customer>
    {
        public Customer Initialize()
        {
            var defaultCustomer = new Customer
                                  {
                                      CustomerGuid = Guid.NewGuid(),
                                      CreatedOnUtc = DateTime.UtcNow,
                                      LastActivityDateUtc = DateTime.UtcNow,
                                      Active = true
                                  };

            return defaultCustomer;
        }
    }
}
