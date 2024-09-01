using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Service
{
    public class studentService
    {

        studentRepository StudentRepository;
        public StudentModel GetStudentById(int id)
        {
            StudentRepository = new studentRepository();
            return StudentRepository.GetById(id);
        }

        public bool AddStudent(StudentModel student)
        {
            StudentRepository = new studentRepository();
            return StudentRepository.Add(student);
    }

    }

    
}
