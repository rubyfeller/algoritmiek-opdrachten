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
        public List<Animal> Animals { get; set; }
        public List<Wagon> Wagons { get; }
        public Wagon wagon = new Wagon();
        List<Animal> carnivores = new List<Animal>();
        List<Animal> herbivores = new List<Animal>();

        public void AddAnimalsToWagon(List<Animal> animals)
        {
            Animals = animals;

            FilterCarnivores();
            FilterHerbivores();
            AddAnimalsToTheWagon();
            LoopThroughWagons();

        }
        public List<Animal> FilterCarnivores()
        {
            foreach (var Animal in Animals.ToList())
            {
                if (Animal.Diet == "Carnivore")
                {
                    carnivores.Add(Animal);
                }
            }
            return carnivores;
        }

        public List<Animal> FilterHerbivores()
        {
            foreach (var Animal in Animals)
            {
                if (Animal.Diet == "Herbivore")
                {
                    herbivores.Add(Animal);
                }
            }
            return herbivores;
        }

        public void AddAnimalsToTheWagon()
        {
            foreach (var carnivore in carnivores.ToList())
            {
                if (wagon.CheckSizeAndDiet(carnivore) == true)
                {
                    // if no wagon exists yet, add a new one
                    if (Wagons.Count <= 0)
                    {
                        wagon = new Wagon();
                        Wagons.Add(wagon);
                        wagon.WagonNumber++;
                        wagon.AddAnimal(carnivore);
                    }
                    else
                    {
                        wagon.AddAnimal(carnivore);
                    }
                    carnivores.Remove(carnivore);
                }
                else
                {
                    wagon = new Wagon();
                    Wagons.Add(wagon);
                    wagon.WagonNumber++;
                    wagon.AddAnimal(carnivore);
                    carnivores.Remove(carnivore);

                }
                foreach (var herbivore in herbivores.ToList())
                {
                    if (wagon.CheckSizeAndDiet(herbivore) == true)
                    {
                        if (Wagons.Count <= 0)
                        {
                            wagon = new Wagon();
                            Wagons.Add(wagon);
                            wagon.WagonNumber++;
                            wagon.AddAnimal(herbivore);
                        }
                        else
                        {
                            wagon.AddAnimal(herbivore);

                        }
                        herbivores.Remove(herbivore);

                    }
                    else
                    {
                        wagon = new Wagon();
                        Wagons.Add(wagon);
                        wagon.WagonNumber++;
                        wagon.AddAnimal(herbivore);
                        herbivores.Remove(herbivore);

                    }
                }
            }
        }
        public void LoopThroughWagons()
        {
            foreach (var wagon in Wagons)
            {
                Console.WriteLine(Wagons);
            }
        }
    }
}