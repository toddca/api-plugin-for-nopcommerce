// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="ActiveApiPluginRequirement.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Microsoft.AspNetCore.Authorization;
using Nop.Core.Infrastructure;
using Nop.Plugin.Api.Domain;

namespace Nop.Plugin.Api.Authorization.Requirements
{
    public class ActiveApiPluginRequirement : IAuthorizationRequirement
    {
        public bool IsActive()
        {
            var settings = EngineContext.Current.Resolve<ApiSettings>();

            if (settings.EnableApi)
            {
                return true;
            }

            return false;
        }
    }
}
