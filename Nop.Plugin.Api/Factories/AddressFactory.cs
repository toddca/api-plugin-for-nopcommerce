// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="AddressFactory.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using Nop.Core.Domain.Common;

namespace Nop.Plugin.Api.Factories
{
    public class AddressFactory : IFactory<Address>
    {
        public Address Initialize()
        {
            var address = new Address
                          {
                              CreatedOnUtc = DateTime.UtcNow
                          };

            return address;
        }
    }
}
