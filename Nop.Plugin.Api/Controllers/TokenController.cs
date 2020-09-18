// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="TokenController.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Api.Helpers;
using Nop.Plugin.Api.Models.Authentication;

namespace Nop.Plugin.Api.Controllers
{
    [AllowAnonymous]
    public class TokenController : Controller
    {
        private readonly TokenHelper _tokenHelper;

        public TokenController(TokenHelper tokenHelper)
        {
            _tokenHelper = tokenHelper;
        }

        [Route("/token")]
        [HttpPost]
        public IActionResult Create([FromBody] TokenRequest model)
        {
            return Json(_tokenHelper.CreateToken(model));
        }
    }
}
