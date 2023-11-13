using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService 
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> GetAllByCategoryId(int Id)
        {
            return _courseDal.GetAll(c => c.CategoryId==Id);
        }

        public List<Course> GetAllByInstructorId(int Id)
        {
            return _courseDal.GetAll(c => c.InstructorId == Id);
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
    }
}
