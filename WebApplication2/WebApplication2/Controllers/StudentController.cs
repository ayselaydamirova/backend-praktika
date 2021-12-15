using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class StudentController
    {
        private List<Student> _students;
        public StudentController()
        {
            _students = new List<Student>
            {
                new Student{Id = 1,Name="Hesen",Surname="Seyfullayev",GroupNo="P201"},
                new Student{Id = 2,Name="Elnur",Surname="Huseynov",GroupNo="P200"},
                new Student{Id = 3,Name="Elnur",Surname="Akula",GroupNo="P202"},
                new Student{Id = 4,Name="Togrul",Surname="Niva",GroupNo="P201"}
            };
        }
}
