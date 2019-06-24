// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="IFactory.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

namespace Nop.Plugin.Api.Factories
{
    public interface IFactory<T>
    {
        T Initialize();
    }
}
