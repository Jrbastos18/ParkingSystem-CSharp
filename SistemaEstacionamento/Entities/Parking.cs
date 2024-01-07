using System.Globalization;

namespace SistemaEstacionamento.Entities
{
    internal class Parking
    {
        //Class properties
        public double InitialPrice { get; private set; }
        public double PricePerHour { get; private set; }
        List<string> ListVehicle = new List<string>();

        //Class constructor
        public Parking(double initialPrice, double pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        //Class methods

        //Method to add a vehicle
        public void AddVehicle()
        {
            Console.Write("Enter the vehicle's license plate to park: ");
            string vehicle = Console.ReadLine();

            ListVehicle.Add(vehicle);
        }

        //Method to remove a vehicle
        public void RemoveVehicle()
        {
            Console.Write("Enter the vehicle's license plate to remove: ");
            string licensePlate = Console.ReadLine();

            //Conditional structure to check if the vehicle exists
            if (ListVehicle.Any(x => x.ToUpper() == licensePlate.ToUpper()))
            {
                Console.Write("Enter the number of hours the vehicle was parked: ");
                int hoursParked = int.Parse(Console.ReadLine());

                double totalValue = InitialPrice + PricePerHour * hoursParked;

                ListVehicle.Remove(licensePlate);

                Console.WriteLine($"The vehicle {licensePlate} was removed and the total price was: R${totalValue.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Sorry, that vehicle is not parked here. Check if you typed the license plate correctly");
            }
        }

        //Method for listing vehicles
        public void ListVehicles()
        {
            //Conditional structure to check if there are vehicles in the parking lot
            if (ListVehicle.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                foreach (string vehicle in ListVehicle)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }

    }
}
