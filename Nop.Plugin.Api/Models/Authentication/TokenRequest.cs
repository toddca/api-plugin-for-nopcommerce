// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="TokenRequest.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

namespace Nop.Plugin.Api.Models.Authentication
{
    public class TokenRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
