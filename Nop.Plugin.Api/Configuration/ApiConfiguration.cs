// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="ApiConfiguration.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

namespace Nop.Plugin.Api.Configuration
{
    public class ApiConfiguration
    {
        public int AllowedClockSkewInMinutes { get; set; } = 5;

        public string SecurityKey { get; set; }
    }
}
