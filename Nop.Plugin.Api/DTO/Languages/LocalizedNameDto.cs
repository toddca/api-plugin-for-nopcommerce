// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="LocalizedNameDto.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
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
