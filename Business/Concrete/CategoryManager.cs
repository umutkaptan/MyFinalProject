using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        //Ben categorymanager olarak veri erişim katmanına bağımlıyım ama zayıf bağımlıyım.Çünkü ben referans üzerinden,//interface üzerinden bağımlıyım o yüzden DataAccessde istediğimiz kadar at koşturabiliriz yeter ki kurallara uyalım.
        public CategoryManager(ICategoryDal categoryDal)    
        {                                                   
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId == categoryId);
        }
    }
}
