using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Service
{
    
    public class CourseService
    {
        courseRepository _CourseRepository;

        public CourseModel GetCourseById(int id)
        {
            _CourseRepository = new courseRepository();
            return _CourseRepository.GetById(id);   
        }
    }
}
