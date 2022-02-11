using System.Collections.Generic;

namespace ConsoleApp10.Controller
{
    public class StudentController
    {
        public List<Model.Student> Students
        { get; private set; }

        public StudentController()
        {
            Students = new List<Model.Student>();
        }

        public void AddStudent ( string name ,
            string group)
        {
            Students.Add(new Model.Student
            {
                Name = name,
                Group = group
            });
        }

    }
}
