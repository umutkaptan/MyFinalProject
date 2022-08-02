using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);   //Categoryıd sine göre tümünü getir.E ticaret sitesinde sol tarafta kategoriyi seçtiğinde kategoriye göre getiren kodu yazıyoruz.
        List<Product> GetByUnitPrice(decimal min,decimal max);  //İki fiyat aralığında olan datayı getirmek için kullanıcaz.



    }
}
