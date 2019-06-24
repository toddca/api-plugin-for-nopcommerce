// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="NewsLetterSubscriptionsRootObject.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.NewsLetterSubscriptions
{
    public class NewsLetterSubscriptionsRootObject : ISerializableObject
    {
        public NewsLetterSubscriptionsRootObject()
        {
            NewsLetterSubscriptions = new List<NewsLetterSubscriptionDto>();
        }

        [JsonProperty("news_letter_subscriptions")]
        public IList<NewsLetterSubscriptionDto> NewsLetterSubscriptions { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "news_letter_subscriptions";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(NewsLetterSubscriptionDto);
        }
    }
}
