using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{     
    //Generic Repository Design Pattern yapıcaz çünkü Kategori ve Ürünler listesindeki şeyler aynı.
    public interface ICategoryDal:IEntityRepository<Category>
    {
      
    }
}
