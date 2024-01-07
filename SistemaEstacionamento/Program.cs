using System.Globalization;
using SistemaEstacionamento.Entities;

namespace SistemaEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the parking system");

            Console.Write("Enter starting price: ");
            double initialPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Now, enter the price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instantiates the parking class with the values obtained previously
            Parking pa = new Parking(initialPrice, pricePerHour);

            string option = string.Empty;
            bool showMenu = true;

            //Perform the menu loop while the showMenu is true
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Enter your option:");
                Console.WriteLine("1 - Register vehicle");
                Console.WriteLine("2 - Remove vehicle");
                Console.WriteLine("3 - List vehicles");
                Console.WriteLine("4 - Close");

                switch(Console.ReadLine())
                {
                    case "1":
                        pa.AddVehicle();
                        break;
                    case "2":
                        pa.RemoveVehicle();
                        break;
                    case "3":
                        pa.ListVehicles();
                        break;
                    case "4":
                        showMenu = false; 
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }

            Console.WriteLine("The program ended!");
        }
    }
}
