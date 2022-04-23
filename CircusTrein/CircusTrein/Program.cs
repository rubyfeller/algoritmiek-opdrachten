using CircusTrein.Logic.Enums;
using CircusTrein.Logic.Models;

Console.WriteLine("Hello Circus Train");

// Generate carnivores
Size size = new Size();
var carnivoreSize = size.GenerateSize();
Carnivore carnivore = new Carnivore((int)carnivoreSize);
carnivore.Size = (int)carnivoreSize;
Console.WriteLine("Size carnivore: " + carnivoreSize);

// Generate herbivores
var herbivoreSize = size.GenerateSize();
Herbivore herbivore = new Herbivore((int)herbivoreSize);
herbivore.Size = (int)herbivoreSize;
Console.WriteLine("Size herbivore: " + herbivoreSize);