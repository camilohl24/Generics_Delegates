
namespace Backend
{
    public delegate void MaintenanceTask(Vehicle vehicle);
    public class Taller
    {


        public void CheckMiliage(Vehicle vehicle)
        {
            if (vehicle.Miliage > 10000)
            {
                Console.WriteLine($"The vehicle {vehicle.Brand} required maintenance");
            }
            else
            {
                Console.WriteLine($"The vehicle {vehicle.Brand} in good condition");
            }
            Console.WriteLine();
        }


        public void checKEngine(Vehicle vehicle)
        {
            if (vehicle.Miliage == 12000)
            {
                Console.WriteLine($"Checking engine of {vehicle.Brand} Needs reapair");
            }
            else
            {
                Console.WriteLine($"Checking engine of {vehicle.Brand} in good condition");
            }
            Console.WriteLine();
        }

        public void CheckBreakes(Vehicle vehicle)
        {
            if (vehicle.Miliage == 12000)
            {
                Console.WriteLine($"Checking brakes of {vehicle.Brand} Needs reapair");
            }
            else
            {
                Console.WriteLine($"Checking brakes of {vehicle.Brand} in good condition");
            }
            Console.WriteLine();
        }
        public void CheckBrand(Vehicle vehicle)
        {
            if (vehicle.Brand == "Hino")
            {
                Console.WriteLine($"The vehicle {vehicle.Brand} is a truck, needs special maintenance");
            }
            else
            {
                Console.WriteLine($"The vehicle {vehicle.Brand} is a car, standard maintenance");
            }
            Console.WriteLine();
        }

        public void VehicleOnQueue(Vehicle vehicle)
        {
            Console.WriteLine($"Vehicle:\t{vehicle.Brand} en espera\n");
        }
        public void RegisterVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Vehiculo:\t{vehicle.Brand}  !registrado con exito¡");
        }

    }


}

