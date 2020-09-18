// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="SpecificationAttributeDto.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.SpecificationAttributes
{
    [JsonObject(Title = "specification_attribute")]
    //[Validator(typeof(SpecificationAttributeDtoValidator))]
    public class SpecificationAttributeDto
    {
        /// <summary>
        ///     Gets or sets the id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the display order
        /// </summary>
        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }

        /// <summary>
        ///     Gets or sets the specification attribute options
        /// </summary>
        [JsonProperty("specification_attribute_options")]
        public List<SpecificationAttributeOptionDto> SpecificationAttributeOptions { get; set; }
    }
}
