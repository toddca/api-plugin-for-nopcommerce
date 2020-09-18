// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="SpecificationAttributesRootObjectDto.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.SpecificationAttributes
{
    public class SpecificationAttributesRootObjectDto : ISerializableObject
    {
        public SpecificationAttributesRootObjectDto()
        {
            SpecificationAttributes = new List<SpecificationAttributeDto>();
        }

        [JsonProperty("specification_attributes")]
        public IList<SpecificationAttributeDto> SpecificationAttributes { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "specification_attributes";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(SpecificationAttributeDto);
        }
    }
}
