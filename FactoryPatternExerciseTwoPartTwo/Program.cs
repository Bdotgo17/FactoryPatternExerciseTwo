using System;

namespace FactoryPatternExerciseTwoPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to work with?");
            Console.WriteLine("Type: SQL");
            Console.WriteLine("Type: mongo");
            Console.WriteLine("Type: list");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price {item.Price}");
            }

        }
    }
}

