// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="NewsLetterSubscriptoonDtoMappings.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Messages;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.NewsLetterSubscriptions;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class NewsLetterSubscriptoonDtoMappings
    {
        public static NewsLetterSubscriptionDto ToDto(this NewsLetterSubscription newsLetterSubscription)
        {
            return newsLetterSubscription.MapTo<NewsLetterSubscription, NewsLetterSubscriptionDto>();
        }

        public static NewsLetterSubscription ToEntity(this NewsLetterSubscriptionDto newsLetterSubscriptionDto)
        {
            return newsLetterSubscriptionDto.MapTo<NewsLetterSubscriptionDto, NewsLetterSubscription>();
        }
    }
}
