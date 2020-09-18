// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ProductSpecificationAttributesCountParametersModel.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nop.Plugin.Api.ModelBinders;

namespace Nop.Plugin.Api.Models.ProductSpecificationAttributesParameters
{
    // JsonProperty is used only for swagger
    [ModelBinder(typeof(ParametersModelBinder<ProductSpecificationAttributesCountParametersModel>))]
    public class ProductSpecificationAttributesCountParametersModel
    {
        /// <summary>
        ///     Product Id
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        ///     Specification Attribute Option Id
        /// </summary>
        [JsonProperty("specification_attribute_option_id")]
        public int SpecificationAttributeOptionId { get; set; }
    }
}
