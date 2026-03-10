using Backend;

Taller taller  = new Taller();

List<Vehicle> vehicles = new List<Vehicle>()
{ 
    new Vehicle { Brand = "Toyota", Model = "Corolla", Miliage = 12000 },
    new Vehicle { Brand ="Hino",Model = "500",Miliage = 2000 },
    new Vehicle { Brand = "Nissan", Model = "Sentra", Miliage = 8000 }
};

Console.WriteLine("---------------Vehiculos varados en el momento.....................: ");
Console.WriteLine("____________________________________________________________________\n");

Almacen<Vehicle> barados = new Almacen<Vehicle>();

foreach (Vehicle vehicle in vehicles)
{
    barados.Add(vehicle);
}
barados.ShowInventory();
var next1 = barados.GetItem(1);
Console.WriteLine($"___________Siguiente vehiculo por reparar___________________________: \n");
Console.WriteLine(next1);

Console.WriteLine("___________________Resultados de la revision__________________________: \n");
MaintenanceTask  maintenance =  taller.CheckMiliage;
maintenance += taller.CheckBrand;
maintenance += taller.checKEngine;
maintenance += taller.CheckBreakes;
maintenance(next1);

barados.deleteItem(1);
Console.WriteLine("---------------Vehiculos varados en el momento.....................: ");
Console.WriteLine("____________________________________________________________________\n");
barados.ShowInventory();





