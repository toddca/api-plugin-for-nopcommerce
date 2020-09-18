﻿// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="OrderItemsParametersModel.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nop.Plugin.Api.Infrastructure;
using Nop.Plugin.Api.ModelBinders;

namespace Nop.Plugin.Api.Models.OrderItemsParameters
{
    [ModelBinder(typeof(ParametersModelBinder<OrderItemsParametersModel>))]
    public class OrderItemsParametersModel
    {
        public OrderItemsParametersModel()
        {
            Limit = Constants.Configurations.DefaultLimit;
            Page = Constants.Configurations.DefaultPageValue;
            SinceId = 0;
            Fields = string.Empty;
        }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("since_id")]
        public int SinceId { get; set; }

        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}
