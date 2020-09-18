// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="CustomerFactory.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
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
