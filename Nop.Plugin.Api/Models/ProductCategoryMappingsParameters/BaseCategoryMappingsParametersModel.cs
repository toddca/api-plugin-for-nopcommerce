// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="BaseCategoryMappingsParametersModel.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Newtonsoft.Json;

namespace Nop.Plugin.Api.Models.ProductCategoryMappingsParameters
{
    // JsonProperty is used only for swagger
    public class BaseCategoryMappingsParametersModel
    {
        /// <summary>
        ///     Show all the product-category mappings for this product
        /// </summary>
        [JsonProperty("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        ///     Show all the product-category mappings for this category
        /// </summary>
        [JsonProperty("category_id")]
        public int? CategoryId { get; set; }
    }
}
