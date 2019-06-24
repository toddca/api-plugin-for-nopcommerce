// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="IFieldsValidator.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Nop.Plugin.Api.Validators
{
    public interface IFieldsValidator
    {
        //TODO: Why this needs to be dictionary???
        Dictionary<string, bool> GetValidFields(string fields, Type type);
    }
}
