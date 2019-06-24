// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="CustomerRolesRootObject.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.CustomerRoles
{
    public class CustomerRolesRootObject : ISerializableObject
    {
        public CustomerRolesRootObject()
        {
            CustomerRoles = new List<CustomerRoleDto>();
        }

        [JsonProperty("customer_roles")]
        public IList<CustomerRoleDto> CustomerRoles { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "customer_roles";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(CustomerRoleDto);
        }
    }
}
