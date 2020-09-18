// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="IFactory.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
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
