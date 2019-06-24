// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="TokenRequest.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
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
