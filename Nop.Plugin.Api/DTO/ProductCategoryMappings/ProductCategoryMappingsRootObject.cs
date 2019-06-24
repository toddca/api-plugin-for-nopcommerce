// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="ProductCategoryMappingsRootObject.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
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
