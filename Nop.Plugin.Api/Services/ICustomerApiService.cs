// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ICustomerApiService.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Nop.Core.Domain.Customers;
using Nop.Plugin.Api.DTO.Customers;
using Nop.Plugin.Api.Infrastructure;

namespace Nop.Plugin.Api.Services
{
    public interface ICustomerApiService
    {
        int GetCustomersCount();

        CustomerDto GetCustomerById(int id, bool showDeleted = false);

        Customer GetCustomerEntityById(int id);

        IList<CustomerDto> GetCustomersDtos(
            DateTime? createdAtMin = null,
            DateTime? createdAtMax = null,
            int limit = Constants.Configurations.DefaultLimit,
            int page = Constants.Configurations.DefaultPageValue,
            int sinceId = Constants.Configurations.DefaultSinceId);

        IList<CustomerDto> Search(
            string query = "",
            string order = Constants.Configurations.DefaultOrder,
            int page = Constants.Configurations.DefaultPageValue,
            int limit = Constants.Configurations.DefaultLimit);

        Dictionary<string, string> GetFirstAndLastNameByCustomerId(int customerId);
    }
}
