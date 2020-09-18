// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="DiscountDtoMappings.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Discounts;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.Discounts;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class DiscountDtoMappings
    {
        public static DiscountDto ToDto(this Discount discount)
        {
            return discount.MapTo<Discount, DiscountDto>();
        }
    }
}
