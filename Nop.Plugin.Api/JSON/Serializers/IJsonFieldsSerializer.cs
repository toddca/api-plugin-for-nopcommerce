// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="IJsonFieldsSerializer.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Plugin.Api.DTO;

namespace Nop.Plugin.Api.JSON.Serializers
{
    public interface IJsonFieldsSerializer
    {
        string Serialize(ISerializableObject objectToSerialize, string fields);
    }
}
