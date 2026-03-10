using Backend;

Taller espera  = new Taller();
List < Vehicle > buses = new List<Vehicle>()
{
    new Vehicle{Brand = "Hino", Miliage = 200000,Model =  "2025"},
    new Vehicle{Brand = "Hino", Miliage = 50000,Model = "2021"}

};


Almacen<Vehicle> parqueo = new Almacen<Vehicle>();
foreach (Vehicle v in buses)
{
    parqueo.Add(v);
}

Console.WriteLine($"____________Usando delagate_______________________:\n");
Console.WriteLine("Vehiculo en parqueo por atender....................:\n");
MaintenanceTask tarea = espera.VehicleOnQueue;
var bus  = parqueo.GetItem(0);
tarea(bus);
Console.WriteLine("____________Usando Action y func_________________\n");

Action<Vehicle> RegistrarVehiculo = espera.RegisterVehicle;
Vehicle bus1 = new Vehicle { Brand = "mercedez", Model = "2020", Miliage = 29999, Consumption = 40 };
RegistrarVehiculo += espera.CheckBrand;
RegistrarVehiculo(bus1);

Func<Vehicle, string> MostrarModelo = (vehicle) => $"El modelo de este vehiculo es {vehicle.Brand}";
var model = MostrarModelo(bus1);
Console.WriteLine(model);



Func<Vehicle, int> TotalConsumption = (vehicle) => vehicle.Miliage / vehicle.Consumption;
var consumption  = TotalConsumption(bus1);

Console.WriteLine($"Total consumo de combustible en todo  su recorrido {consumption} galones");