﻿// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ProductManufacturerMappingDtoMappings.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Catalog;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.ProductManufacturerMappings;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class ProductManufacturerMappingDtoMappings
    {
        public static ProductManufacturerMappingsDto ToDto(this ProductManufacturer mapping)
        {
            return mapping.MapTo<ProductManufacturer, ProductManufacturerMappingsDto>();
        }
    }
}
