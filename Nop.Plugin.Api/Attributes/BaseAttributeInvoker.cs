// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="BaseAttributeInvoker.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Nop.Plugin.Api.Attributes
{
    public abstract class BaseValidationAttribute : Attribute
    {
        public abstract void Validate(object instance);
        public abstract Dictionary<string, string> GetErrors();
    }
}
