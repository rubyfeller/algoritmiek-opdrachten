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
            Animals.Add(new Herbivore("Deer", 5, "Herbivore"));
            Animals.Add(new Herbivore("Deer", 1, "Herbivore"));
            Animals.Add(new Herbivore("Deer", 3, "Herbivore"));
            Animals.Add(new Herbivore("Rabbits", 1, "Herbivore"));
            Animals.Add(new Herbivore("Rabbits", 1, "Herbivore"));
            Animals.Add(new Carnivore("Cat", 3, "Carnivore"));
            Animals.Add(new Carnivore("Cat", 3, "Carnivore"));

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
                    wagon.WagonNumber++;
                    wagon.AddAnimal(animal);
                    Console.WriteLine("Wagon" + wagon.WagonNumber + "Animal" + animal.Name);
                }
                Wagons.Add(wagon);
            }
        }
    }
}
