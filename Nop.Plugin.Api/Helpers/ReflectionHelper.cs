// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ReflectionHelper.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.Helpers
{
    public static class ReflectionHelper
    {
        public static bool HasProperty(string propertyName, Type type)
        {
            return type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) != null;
        }

        public static JsonObjectAttribute GetJsonObjectAttribute(Type objectType)
        {
            var jsonObject = objectType.GetCustomAttribute(typeof(JsonObjectAttribute)) as JsonObjectAttribute;

            return jsonObject;
        }

        public static Type GetGenericElementType(Type type)
        {
            return type.HasElementType
                       ? type.GetElementType()
                       : type.GetTypeInfo().GenericTypeArguments[0];
        }
    }
}
