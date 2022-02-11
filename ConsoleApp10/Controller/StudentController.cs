using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp10.Controller
{
   public delegate void PrintDelegate(string message);

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


        public void PrintStudent (PrintDelegate print)
        {
            foreach (var st in Students)
            {
                Thread.Sleep(1000);
               print  ($"{st.Name} - { st.Group}");
            }
        }

    }
}
