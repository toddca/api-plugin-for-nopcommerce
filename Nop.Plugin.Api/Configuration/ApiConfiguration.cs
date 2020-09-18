// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ApiConfiguration.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

namespace Nop.Plugin.Api.Configuration
{
    public class ApiConfiguration
    {
        public int AllowedClockSkewInMinutes { get; set; } = 5;

        public string SecurityKey { get; set; } = "NowIsTheTimeForAllGoodMenToComeToTheAideOfTheirCountry";
    }
}
