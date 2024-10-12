using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicios
{
    internal class Program
    {

        #region Constructor
        public class People
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public eGender Gender { get; set; }

            public People(string name, int age, eGender gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }
        }
        #endregion

        #region Enums
        public enum eGender
        {
            Undefined,
            Female,
            Male,
        }

        #endregion
        private static void Main(string[] args)
        {
            #region Properties
            List<People> employees = new()
            {
     

            };
            List<People> students = new() { };
            #endregion

            //Empleados
            employees.Add(new People("Ricardo", 34, eGender.Male));
            employees.Add(new People("Maria", 20, eGender.Female));
            employees.Add(new People("Andrea", 25, eGender.Female));
            employees.Add(new People("Valerio", 31, eGender.Male));

            //Estudiantes
            students.Add(new People("Becker", 23, eGender.Male));
            students.Add(new People("Sara", 25, eGender.Male));
            students.Add(new People("Lucero", 21, eGender.Male));
            students.Add(new People("Armando", 27, eGender.Male));
            students.Add(new People("Emilio", 30, eGender.Male));
            students.Add(new People("Daniel", 32, eGender.Male));


            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Gender: {employee.Gender}");
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {employ.Gender}");
            }

            Console.ReadKey();
        }



    }

}
