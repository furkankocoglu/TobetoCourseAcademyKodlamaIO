using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //public void Add(Category category)
        //{
        //    //Business çalıştırılır
        //    AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
        //    categoryDal.Add(category);
        //}

        //public void Add(Course course1)
        //{
        //    Console.WriteLine(course1.Name + " Eklendi.");
        //}

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
