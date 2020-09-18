// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="IJsonHelper.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;

namespace Nop.Plugin.Api.Helpers
{
    public interface IJsonHelper
    {
        Dictionary<string, object> GetRequestJsonDictionaryFromStream(Stream stream, bool rewindStream);
        string GetRootPropertyName<T>() where T : class, new();
    }
}
