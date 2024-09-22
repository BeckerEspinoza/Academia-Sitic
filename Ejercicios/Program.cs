using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        /*  string courseName = "Academia SITIC";
          String courseName2 = "AcademiaSITIC";

          int studentCount = 28;
          bool isStartingNow = true;

          int? age = null;
          age = 23;

          Console.WriteLine(age != null ? age : 0);
          Console.ReadKey(); */

        //------------------------------------------------

        //METODOS
        int a = 5;
        int b = 10;

        Console.WriteLine(SumInteger(a, b));
        Console.ReadKey();
    }

    public static int SumInteger(int a, int b)
    {
        a = b;
        return a + b;
    }

    public class User
    {
        
        //Forma corta
        public int IdUser { get; set; }

        //Forma larga
        private string _name;
        public string GetName()
        {
            return _name;
        }

        public string SetName(string name)
        {
            return name;
        }
    }

    public class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }
    }
}