﻿using _01._Vehicles;

// Read the vehicle data // Format: [VehicleType] [double initial fuelQuantity] [double fuelConsumption]
// NB: The order of the vehicles is known for the input. That is why I cast from the second argument
double[] carDetails = Console.ReadLine()!.Split()[1..].Select(double.Parse).ToArray();
double[] truckDetails = Console.ReadLine()!.Split()[1..].Select(double.Parse).ToArray();

List<Vehicle> vehicles = new()
{
    new Car(carDetails[0], carDetails[1]),
    new Truck(truckDetails[0], truckDetails[1])
};

uint commandLinesCount = uint.Parse(Console.ReadLine()!);
for (int i = 0; i < commandLinesCount; i++)
{
    string[] commandDetails = Console.ReadLine()!.Split();
    string command = commandDetails[0];
    string vehicleType = commandDetails[1];

    Vehicle vehicle = vehicles.Find(v => v.GetType().Name == vehicleType)!;
    if (command == "Drive") vehicle.Drive(double.Parse(commandDetails[2]));
    else if (command == "Refuel") vehicle.Refuel(double.Parse(commandDetails[2]));
}

foreach (Vehicle vehicle in vehicles) Console.WriteLine(vehicle);