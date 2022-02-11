using System;
using ConsoleApp10.Controller;
namespace ConsoleApp10
{
    class Program
    {

        static void Main(string[] args)
        {

            StudentController controller =
                new StudentController();

            controller.AddStudent("Иван", "ИС-20-02");
            controller.AddStudent("Петя", "ИС-20-02");
            controller.AddStudent("Лена", "ИС-20-02");
            controller.AddStudent("Саша", "ИС-20-02");
            controller.AddStudent("Егор", "ИС-20-02");

            PrintDelegate print = MyPrint;
            controller.PrintStudent(print);
        }

        private static void MyPrint(string message)
        {
            Console.WriteLine(message);
        }
    }
}






















