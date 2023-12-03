using System;
using System.Collections.Generic;

// Клас Дорога
class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Lanes { get; set; }
    public int TrafficLevel { get; set; }
}

// Клас Транспортний засіб
class Vehicle
{
    public int Speed { get; set; }
    public int Size { get; set; }
    public string VehicleType { get; set; }
}

// Інтерфейс
interface IDriveable
{
    void Move();
    void Stop();
}

// Реалізація класу для імітації руху транспортних засобів
class TrafficSimulation : IDriveable
{
    private readonly Vehicle vehicle;

    public TrafficSimulation(Vehicle vehicle)
    {
        this.vehicle = vehicle;
    }

    public void Move()
    {
        Console.WriteLine($"{vehicle.VehicleType} is moving with speed {vehicle.Speed} km/h.");
    }

    public void Stop()
    {
        Console.WriteLine($"{vehicle.VehicleType} has stopped.");
    }
}

// Реалізація класу Симуляція
class Simulation
{
    private readonly List<Road> roads = new List<Road>();
    private readonly List<Vehicle> vehicles = new List<Vehicle>();

    public void AddRoad(Road road)
    {
        roads.Add(road);
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void OptimizeTraffic()
    {
        // Реалізуйте логіку оптимізації трафіку тут
    }
}
