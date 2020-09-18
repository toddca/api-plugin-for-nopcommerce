// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ProductManufacturerMappingsCountRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.ProductManufacturerMappings
{
    public class ProductManufacturerMappingsCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
