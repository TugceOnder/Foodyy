using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class CatogoryManager : ICategoryService 
    {

        private readonly ICategoryDal _categoryDal;

        public CatogoryManager(ICategoryDal icategoryDal)
        {
            _categoryDal = icategoryDal;
        }
        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> TgetAll()
        {
            return _categoryDal.getAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
