// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="IProductPictureService.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Catalog;

namespace Nop.Plugin.Api.Services
{
    public interface IProductPictureService
    {
        ProductPicture GetProductPictureByPictureId(int pictureId);
    }
}
