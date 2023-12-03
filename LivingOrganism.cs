using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class LivingOrganism
{
    public int Energy { get; set; }
public int Age { get; set; }
public int Size { get; set; }
}

// Спадкоємні класи
class Animal : LivingOrganism
{
    public string Species { get; set; }
}

class Plant : LivingOrganism
{
    public string Type { get; set; }
}

class Microorganism : LivingOrganism
{
    public string Classification { get; set; }
}

// Інтерфейси
interface IReproducible
{
    void Reproduce();
}

interface IPredator
{
    void Hunt(LivingOrganism target);
}

// Реалізація класу Екосистема
class Ecosystem
{
    private readonly List<LivingOrganism> organisms = new List<LivingOrganism>();

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateInteraction()
    {
        Random random = new Random();

        foreach (var organism in organisms)
        {
            if (organism is IReproducible && random.Next(2) == 0)
            {
                ((IReproducible)organism).Reproduce();
            }

            if (organism is IPredator)
            {
                var target = organisms[random.Next(organisms.Count)];
                ((IPredator)organism).Hunt(target);
            }
        }
    }
}