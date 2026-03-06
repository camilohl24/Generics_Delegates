

Console.WriteLine("Vehicle Inspection");

void CheckBrakes(string vehicle) => Console.WriteLine($"Checking brakes of {vehicle}");
InspectVehicle maintenance = CheckBrakes;
maintenance("nkd");
void CheckEngine(string vehicule) => Console.WriteLine($"Checking engine of {vehicule}");
void ChecKTransmission(string vehicule) => Console.WriteLine($"Checking transmission of {vehicule}");

maintenance = CheckEngine;
maintenance("nkd");

Console.WriteLine("New vehicle Inspection");


InspectVehicle CompleteMaintenance = CheckBrakes;
CompleteMaintenance += CheckEngine;
CompleteMaintenance += ChecKTransmission;
CompleteMaintenance("TTR 200");

Console.WriteLine("After removing brakes check from the maintenance process");
CompleteMaintenance -= CheckBrakes;
CompleteMaintenance("TTR 125");
delegate void InspectVehicle(string vehicle);