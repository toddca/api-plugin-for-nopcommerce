// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="IManufacturerApiService.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Nop.Core.Domain.Catalog;
using Nop.Plugin.Api.Infrastructure;

namespace Nop.Plugin.Api.Services
{
    public interface IManufacturerApiService
    {
        Manufacturer GetManufacturerById(int manufacturerId);

        IList<Manufacturer> GetManufacturers(
            IList<int> ids = null,
            DateTime? createdAtMin = null,
            DateTime? createdAtMax = null,
            DateTime? updatedAtMin = null,
            DateTime? updatedAtMax = null,
            int limit = Constants.Configurations.DefaultLimit,
            int page = Constants.Configurations.DefaultPageValue,
            int sinceId = Constants.Configurations.DefaultSinceId,
            int? productId = null,
            bool? publishedStatus = null,
            int? languageId = null);

        int GetManufacturersCount(
            DateTime? createdAtMin = null,
            DateTime? createdAtMax = null,
            DateTime? updatedAtMin = null,
            DateTime? updatedAtMax = null,
            bool? publishedStatus = null,
            int? productId = null);
    }
}
