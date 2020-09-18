// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="LocalizedNameDto.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Languages
{
    public class LocalizedNameDto
    {
        /// <summary>
        ///     Gets or sets the language identifier
        /// </summary>
        [JsonProperty("language_id")]
        public int? LanguageId { get; set; }

        /// <summary>
        ///     Gets or sets the localized name
        /// </summary>
        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }
    }
}
