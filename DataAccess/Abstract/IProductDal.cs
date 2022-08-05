using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>       //Veri erişim işlerini yapacak interface..
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
