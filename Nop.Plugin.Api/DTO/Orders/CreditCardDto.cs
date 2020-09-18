// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="CreditCardDto.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Orders
{
    public class CreditCardDto
    {
        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_expiration")]
        public string CardExpiry { get; set; }
    }
}
