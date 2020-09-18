// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="AddressFactory.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
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
