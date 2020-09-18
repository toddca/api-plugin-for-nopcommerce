// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="CustomerRoleDtoMappings.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Customers;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.CustomerRoles;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class CustomerRoleDtoMappings
    {
        public static CustomerRoleDto ToDto(this CustomerRole customerRole)
        {
            return customerRole.MapTo<CustomerRole, CustomerRoleDto>();
        }
    }
}
