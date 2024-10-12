//using System.ComponentModel;
//using System.Diagnostics;
//using System.Security.Cryptography.X509Certificates;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int initialStock = 50;
//        int quantityToAdd = 20;
//        int addedQuantity;

//        updateStock(initialStock, quantityToAdd, out int updatedStock, out addedQuantity);

        


//        Console.ReadKey();
//    }

//    public static void updateStock(int initialStock, int quantityToAdd, out int updatedStock, out int addedQuantity)
//    {
//        addedQuantity = quantityToAdd;
//        updatedStock = initialStock + quantityToAdd;
//    }

//    public static void AdjustStock(ref int stock, int adjustment)
//    {
        
//    }

//    public static (string, int) GetProductInfo(string productName, int stock)
//    {
//        return (productName, stock);
//    }

//    public static int SumInteger(int a, int b)
//    {
//        a = b;
//        return a + b;
//    }

//    public class User
//    {
        
//        //Forma corta
//        public int IdUser { get; set; }

//        //Forma larga
//        private string _name;
//        public string GetName()
//        {
//            return _name;
//        }

//        public string SetName(string name)
//        {
//            return name;
//        }
//    }

//    public class Person
//    {
//        public int PersonId { get; set; }

//        public string Name { get; set; }
//    }
//}