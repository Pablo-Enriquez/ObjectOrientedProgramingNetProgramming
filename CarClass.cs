using System;


namespace CarClass
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to the Car Inventory Application!");

            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("\nEnter the following car details:");

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Price of the car: ");
                double price = double.Parse(Console.ReadLine());

                Car car = new Car(model, year, price);

                Console.WriteLine("\nThe following are the car details:");
                Console.WriteLine(car);

                Console.WriteLine($"The estimated price after depreciation is: ${car.CalculateDepreciation():N2}");

                Console.Write("\nWould you like to enter antoher car? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                continueLoop = response == "yes";
            }

            Console.WriteLine("Thank you for using the Car Inventory Application! Come back soon!");
    }
}