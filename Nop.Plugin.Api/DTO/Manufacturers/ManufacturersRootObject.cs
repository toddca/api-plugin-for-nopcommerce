// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="ManufacturersRootObject.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Manufacturers
{
    public class ManufacturersRootObject : ISerializableObject
    {
        public ManufacturersRootObject()
        {
            Manufacturers = new List<ManufacturerDto>();
        }

        [JsonProperty("manufacturers")]
        public IList<ManufacturerDto> Manufacturers { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "manufacturers";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(ManufacturerDto);
        }
    }
}
