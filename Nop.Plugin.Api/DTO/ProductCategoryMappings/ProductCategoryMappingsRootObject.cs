// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ProductCategoryMappingsRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.ProductCategoryMappings
{
    public class ProductCategoryMappingsRootObject : ISerializableObject
    {
        public ProductCategoryMappingsRootObject()
        {
            ProductCategoryMappingDtos = new List<ProductCategoryMappingDto>();
        }

        [JsonProperty("product_category_mappings")]
        public IList<ProductCategoryMappingDto> ProductCategoryMappingDtos { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "product_category_mappings";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(ProductCategoryMappingDto);
        }
    }
}
