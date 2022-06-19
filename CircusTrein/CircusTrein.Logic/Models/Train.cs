namespace CircusTrein.Logic.Models
{
    public class Train
    {
        private List<Animal> Animals { get; set; }
        public List<Wagon> Wagons { get; }

        readonly List<Animal> carnivores = new List<Animal>();
        readonly List<Animal> herbivores = new List<Animal>();
        List<Animal> sortedCarnivores = new List<Animal>();
        List<Animal> sortedHerbivores = new List<Animal>();

        public Train()
        {
            Animals = new List<Animal>();
            Wagons = new List<Wagon>();
        }

        public void AddAnimals(List<Animal> animals)
        {
            Animals = animals;

            sortedCarnivores = FilterCarnivores();
            sortedHerbivores = FilterHerbivores();

            if (sortedCarnivores.Count > 0)
            {
                AddCarnivoresToWagons();
            }

        }

        private List<Animal> FilterCarnivores()
        {
            foreach (var Animal in Animals.ToList())
            {
                if (Animal.DoesAnimalEat())
                {
                    carnivores.Add(Animal);
                }
            }
            sortedCarnivores = carnivores.OrderByDescending(x => x.Size).ToList();
            return sortedCarnivores;
        }

        private List<Animal> FilterHerbivores()
        {
            foreach (var Animal in Animals)
            {
                if (Animal.DoesAnimalEat() == false)
                {
                    herbivores.Add(Animal);
                }
            }
            sortedHerbivores = herbivores.OrderBy(x => x.Size).ToList();
            return sortedHerbivores;
        }

        private void AddCarnivoresToWagons()
        {
            Wagon wagon = new Wagon();
            foreach (var currCarnivore in sortedCarnivores.ToList())
            {
                if (wagon.CheckSizeAndDiet(currCarnivore))
                {
                    // if no wagon exists yet, add a new one
                    if (Wagons.ToList().Count <= 0)
                    {
                        wagon = new Wagon();
                        Wagons.Add(wagon);
                        wagon.AddAnimalToWagon(currCarnivore);
                    }
                    else
                    {
                        wagon.AddAnimalToWagon(currCarnivore);
                    }
                }
                else
                {
                    wagon = new Wagon();
                    Wagons.Add(wagon);
                    wagon.AddAnimalToWagon(currCarnivore);

                }
            }
            AddHerbivoresToWagons();
        }

        private void AddHerbivoresToWagons()
        {
            foreach (var currHerbivore in sortedHerbivores.ToList())
            {
                bool isAdded = false;
                foreach (var currWagon in Wagons.ToList())
                {
                    if (currWagon.CheckSizeAndDiet(currHerbivore) && isAdded == false)
                    {
                        currWagon.AddAnimalToWagon(currHerbivore);
                        isAdded = true;
                    }
                }
                if (isAdded == false)
                {
                    Wagon wagon = new Wagon();
                    Wagons.Add(wagon);
                    wagon.AddAnimalToWagon(currHerbivore);

                }
            }
        }
    }
}
