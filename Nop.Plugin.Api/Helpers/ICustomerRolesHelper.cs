// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ICustomerRolesHelper.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using Nop.Core.Domain.Customers;

namespace Nop.Plugin.Api.Helpers
{
    public interface ICustomerRolesHelper
    {
        IList<CustomerRole> GetValidCustomerRoles(List<int> roleIds);
        bool IsInGuestsRole(IList<CustomerRole> customerRoles);
        bool IsInRegisteredRole(IList<CustomerRole> customerRoles);
    }
}
