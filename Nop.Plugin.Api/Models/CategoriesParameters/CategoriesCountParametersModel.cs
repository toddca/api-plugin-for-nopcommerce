// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="CategoriesCountParametersModel.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Api.ModelBinders;

namespace Nop.Plugin.Api.Models.CategoriesParameters
{
    [ModelBinder(typeof(ParametersModelBinder<CategoriesCountParametersModel>))]
    public class CategoriesCountParametersModel : BaseCategoriesParametersModel
    {
        // Nothing special here, created just for clarity.
    }
}
