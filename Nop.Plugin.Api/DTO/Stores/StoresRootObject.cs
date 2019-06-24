// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="StoresRootObject.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Stores
{
    public class StoresRootObject : ISerializableObject
    {
        public StoresRootObject()
        {
            Stores = new List<StoreDto>();
        }

        [JsonProperty("stores")]
        public IList<StoreDto> Stores { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "stores";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(StoreDto);
        }
    }
}
