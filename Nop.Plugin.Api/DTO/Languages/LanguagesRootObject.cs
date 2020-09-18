// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="LanguagesRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Languages
{
    public class LanguagesRootObject : ISerializableObject
    {
        public LanguagesRootObject()
        {
            Languages = new List<LanguageDto>();
        }

        [JsonProperty("languages")]
        public IList<LanguageDto> Languages { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "languages";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(LanguageDto);
        }
    }
}
