﻿// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ManufacturerFactory.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using Nop.Core.Domain.Catalog;

namespace Nop.Plugin.Api.Factories
{
    public class ManufacturerFactory : IFactory<Manufacturer>
    {
        private readonly CatalogSettings _catalogSettings;

        public ManufacturerFactory(CatalogSettings catalogSettings)
        {
            _catalogSettings = catalogSettings;
        }

        public Manufacturer Initialize()
        {
            // TODO: cache the default entity.
            var defaultManufacturer = new Manufacturer();

            //default values
            defaultManufacturer.PageSize = _catalogSettings.DefaultManufacturerPageSize;
            defaultManufacturer.PageSizeOptions = _catalogSettings.DefaultManufacturerPageSizeOptions;
            defaultManufacturer.Published = true;
            defaultManufacturer.AllowCustomersToSelectPageSize = true;

            defaultManufacturer.CreatedOnUtc = DateTime.UtcNow;
            defaultManufacturer.UpdatedOnUtc = DateTime.UtcNow;

            return defaultManufacturer;
        }
    }
}
