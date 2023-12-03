using System;
using System.Collections.Generic;

// Базовий клас Комп'ютер
class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OSType { get; set; }
}

// Спадкоємні класи
class Server : Computer
{
    public int StorageCapacity { get; set; }
}

class Workstation : Computer
{
    public int GPUPower { get; set; }
}

class Router : Computer
{
    public int DataTransferRate { get; set; }
}

// Інтерфейси
interface IConnectable
{
    void Connect(Computer device);
    void Disconnect(Computer device);
}

// Реалізація класу Мережа
class Network
{
    private readonly List<Computer> devices = new List<Computer>();

    public void AddDevice(Computer device)
    {
        devices.Add(device);
    }

    public void ConnectDevices(Computer device1, Computer device2)
    {
        device1.Connect(device2);
        device2.Connect(device1);
    }

    public void DisconnectDevices(Computer device1, Computer device2)
    {
        device1.Disconnect(device2);
        device2.Disconnect(device1);
    }
}