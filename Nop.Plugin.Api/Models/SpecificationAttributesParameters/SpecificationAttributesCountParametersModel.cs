// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="SpecificationAttributesCountParametersModel.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Api.ModelBinders;

namespace Nop.Plugin.Api.Models.SpecificationAttributesParameters
{
    // JsonProperty is used only for swagger
    [ModelBinder(typeof(ParametersModelBinder<SpecificationAttributesCountParametersModel>))]
    public class SpecificationAttributesCountParametersModel
    {
    }
}
