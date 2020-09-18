// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="IJsonFieldsSerializer.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
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
