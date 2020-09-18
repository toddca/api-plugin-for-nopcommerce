// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="NewsLetterSubscriptionsRootObject.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
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
