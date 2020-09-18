// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="DiscountDto.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Nop.Core.Domain.Discounts;

namespace Nop.Plugin.Api.DTO.Discounts
{
    public class DiscountDto
    {
        /// <summary>
        ///     Gets or sets the id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the coupon code
        /// </summary>
        [JsonProperty("coupon_code")]
        public string CouponCode { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to use percentage
        /// </summary>
        [JsonProperty("use_percentage")]
        public bool UsePercentage { get; set; }

        /// <summary>
        ///     Gets or sets the discount amount
        /// </summary>
        [JsonProperty("discount_amount")]
        public decimal DiscountAmount { get; set; }

        /// <summary>
        ///     Gets or sets the discount percentage
        /// </summary>
        [JsonProperty("discount_percentage")]
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        ///     Gets or sets the maximum discount amount (used with "UsePercentage")
        /// </summary>
        [JsonProperty("maximum_discount_amount")]
        public decimal? MaximumDiscountAmount { get; set; }

        /// <summary>
        ///     Gets or sets the discount start date and time
        /// </summary>
        [JsonProperty("start_date_utc")]
        public DateTime? StartDateUtc { get; set; }

        /// <summary>
        ///     Gets or sets the discount end date and time
        /// </summary>
        [JsonProperty("end_date_utc")]
        public DateTime? EndDateUtc { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether discount requires coupon code
        /// </summary>
        [JsonProperty("requires_coupon_code")]
        public bool RequiresCouponCode { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether discount can be used simultaneously with other discounts (with the same
        ///     discount type)
        /// </summary>
        [JsonProperty("is_cumulative")]
        public bool IsCumulative { get; set; }

        /// <summary>
        ///     Gets or sets the discount limitation times (used when Limitation is set to "N Times Only" or "N Times Per
        ///     Customer")
        /// </summary>
        [JsonProperty("limitation_times")]
        public int LimitationTimes { get; set; }

        /// <summary>
        ///     Gets or sets the maximum product quantity which could be discounted
        ///     Used with "Assigned to products" or "Assigned to categories" type
        /// </summary>
        [JsonProperty("maximum_discounted_quantity")]
        public int? MaximumDiscountedQuantity { get; set; }

        /// <summary>
        ///     Gets or sets value indicating whether it should be applied to all subcategories or the selected one
        ///     Used with "Assigned to categories" type only.
        /// </summary>
        [JsonProperty("applied_to_subcategories")]
        public bool AppliedToSubCategories { get; set; }

        /// <summary>
        ///     Gets or sets the discount type
        /// </summary>
        [JsonProperty("discount_type")]
        [JsonConverter(typeof(StringEnumConverter), true)]
        public DiscountType DiscountType { get; set; }

        /// <summary>
        ///     Gets or sets the discount limitation
        /// </summary>
        [JsonProperty("discount_limitation")]
        [JsonConverter(typeof(StringEnumConverter), true)]
        public DiscountLimitationType DiscountLimitation { get; set; }
    }
}
