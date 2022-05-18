using CircusTrein.Logic.Enums;

namespace CircusTrein.Logic.Models
{
    public class Train
    {

        public Train()
        {
            Carnivores = new List<Carnivore>();
            Herbivores = new List<Herbivore>();
            Animals = new List<Animal>();
            Wagons = new List<Wagon>();
        }

        public List<Carnivore> Carnivores { get; }
        public List<Herbivore> Herbivores { get; }
        public List<Animal> Animals { get; }
        public List<Wagon> Wagons { get; }
        public Wagon wagon = new Wagon();

        public void AddAnimalsToWagon()
        {
            Animals.Add(new Herbivore("Deer", (int)Size.SizeEnum.Large, "Herbivore"));
            Animals.Add(new Herbivore("Deer", (int)Size.SizeEnum.Small, "Herbivore"));
            Animals.Add(new Herbivore("Deer", (int)Size.SizeEnum.Medium, "Herbivore"));
            Animals.Add(new Herbivore("Rabbits", (int)Size.SizeEnum.Small, "Herbivore"));
            Animals.Add(new Herbivore("Rabbits", (int)Size.SizeEnum.Small, "Herbivore"));
            Animals.Add(new Carnivore("Cat", (int)Size.SizeEnum.Medium, "Carnivore"));
            Animals.Add(new Carnivore("Cat", (int)Size.SizeEnum.Medium, "Carnivore"));

            foreach (var animal in Animals)
            {
                if (wagon.CheckSizeAndDiet(animal) == true)
                {
                    Console.WriteLine("Wagon" + wagon.WagonNumber + "Animal" + animal.Name);
                    wagon.AddAnimal(animal);
                }
                else
                {
                    Console.WriteLine("Animal can not be added to wagon");
                    wagon.AddAnimal(animal);
                    Console.WriteLine("Wagon" + wagon.WagonNumber + "Animal" + animal.Name);
                }
                Wagons.Add(wagon);
            }
        }
    }
}
