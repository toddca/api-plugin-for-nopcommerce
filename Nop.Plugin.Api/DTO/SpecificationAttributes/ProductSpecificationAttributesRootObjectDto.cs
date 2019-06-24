// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="ProductSpecificationAttributesRootObjectDto.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.SpecificationAttributes
{
    public class ProductSpecificationAttributesRootObjectDto : ISerializableObject
    {
        public ProductSpecificationAttributesRootObjectDto()
        {
            ProductSpecificationAttributes = new List<ProductSpecificationAttributeDto>();
        }

        [JsonProperty("product_specification_attributes")]
        public IList<ProductSpecificationAttributeDto> ProductSpecificationAttributes { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "product_specification_attributes";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(ProductSpecificationAttributeDto);
        }
    }
}
