using CircusTrein.Logic.Enums;
using CircusTrein.Logic.Models;

Console.WriteLine("Hello Circus Train");
CircusTrain();

static void CircusTrain()
{
    List<Animal> animals = new List<Animal>();

    // Combination 1
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));

    animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));
    animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));
    animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));
    animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));
    animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));

    animals.Add(new Carnivore("Tiger", (int)Size.SizeEnum.Large, "Carnivore"));
    animals.Add(new Carnivore("Tiger", (int)Size.SizeEnum.Large, "Carnivore"));

    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));

    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Small, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Small, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Small, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Small, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Small, "Herbivore"));

    animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));
    animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));
    animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));

    // Combination 2
    //animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));
    //animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    //animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    //animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    //animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));
    //animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));

    Console.WriteLine("Creating train...");

    Train newTrain = new Train();

    Console.WriteLine("Adding animals to wagons...");

    newTrain.AddAnimals(animals);

    foreach (var wagon in newTrain.Wagons)
    {
        Console.WriteLine("----------");

        foreach (var animal in wagon.GetAnimals())
        {
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.Diet);
            Console.WriteLine(animal.Size);
        }
    }
    Console.WriteLine("Total amount of wagons: " + newTrain.Wagons.Count);
}
