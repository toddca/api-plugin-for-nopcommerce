// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="DiscountManufacturerMappingDto.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Newtonsoft.Json;
using Nop.Plugin.Api.DTO.Base;

namespace Nop.Plugin.Api.DTO.Manufacturers
{
    [JsonObject(Title = "discount")]
    //[Validator(typeof(ProductDtoValidator))]
    public class DiscountManufacturerMappingDto : BaseDto
    {
        /// <summary>
        ///     Gets or sets the discount identifier
        /// </summary>
        [JsonProperty("discount_id")]
        public int DiscountId { get; set; }


        [JsonProperty("discount_name")]
        public string DiscountName { get; set; }
    }
}
