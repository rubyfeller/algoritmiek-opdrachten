﻿using CircusTrein.Logic.Enums;
using CircusTrein.Logic.Models;

Console.WriteLine("Hello Circus Train");
CircusTrain();

static void CircusTrain()
{
    List<Animal> animals = new List<Animal>();

    //animals.Add(new Carnivore("Tiger", (int)Size.SizeEnum.Large, "Carnivore"));
    //animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));
    //animals.Add(new Carnivore("Lion", (int)Size.SizeEnum.Medium, "Carnivore"));
    //animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Small, "Herbivore"));
    //animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    //animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));

    animals.Add(new Carnivore("Bear", (int)Size.SizeEnum.Small, "Carnivore"));
    animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));
    animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));
    animals.Add(new Herbivore("Rabbit", (int)Size.SizeEnum.Large, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));
    animals.Add(new Herbivore("Buffalo", (int)Size.SizeEnum.Medium, "Herbivore"));

    Train newTrain = new Train();
    newTrain.AddAnimals(animals);
}
