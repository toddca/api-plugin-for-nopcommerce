﻿// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="CustomerRoleAuthorizationPolicy.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Nop.Plugin.Api.Authorization.Requirements;

namespace Nop.Plugin.Api.Authorization.Policies
{
    public class CustomerRoleAuthorizationPolicy : AuthorizationHandler<CustomerRoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomerRoleRequirement requirement)
        {
            if (requirement.IsCustomerInRole())
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }

            return Task.CompletedTask;
        }
    }
}
