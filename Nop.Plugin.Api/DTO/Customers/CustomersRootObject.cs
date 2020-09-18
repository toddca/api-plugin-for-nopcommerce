// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="CustomersRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Customers
{
    public class CustomersRootObject : ISerializableObject
    {
        public CustomersRootObject()
        {
            Customers = new List<CustomerDto>();
        }

        [JsonProperty("customers")]
        public IList<CustomerDto> Customers { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "customers";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(CustomerDto);
        }
    }
}
