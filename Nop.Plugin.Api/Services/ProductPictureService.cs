// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ProductPictureService.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Linq;
using Nop.Core.Domain.Catalog;
using Nop.Data;

namespace Nop.Plugin.Api.Services
{
    public class ProductPictureService : IProductPictureService
    {
        private readonly IRepository<ProductPicture> _productPictureRepository;

        public ProductPictureService(IRepository<ProductPicture> productPictureRepository)
        {
            _productPictureRepository = productPictureRepository;
        }

        public ProductPicture GetProductPictureByPictureId(int pictureId)
        {
            if (pictureId == 0)
            {
                return null;
            }

            var query = from pp in _productPictureRepository.Table
                        where pp.PictureId == pictureId
                        select pp;

            var productPictures = query.ToList();

            return productPictures.FirstOrDefault();
        }
    }
}
