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
        readonly List<Animal> carnivores = new List<Animal>();
        readonly List<Animal> herbivores = new List<Animal>();
        List<Animal> sortedCarnivores = new List<Animal>();
        List<Animal> sortedHerbivores = new List<Animal>();

        public void AddAnimals(List<Animal> animals)
        {
            Animals = animals;

            sortedCarnivores = FilterCarnivores();
            sortedHerbivores = FilterHerbivores();
            AddCarnivoresToWagon();

        }

        private List<Animal> FilterCarnivores()
        {
            foreach (var Animal in Animals.ToList())
            {
                if (Animal.GetType() == typeof(Carnivore))
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
                if (Animal.GetType() == typeof(Herbivore))
                {
                    herbivores.Add(Animal);
                }
            }
            sortedHerbivores = herbivores.OrderByDescending(x => x.Size).ToList();

            return sortedHerbivores;
        }

        private void AddCarnivoresToWagon()
        {
            foreach (var animal in sortedCarnivores.ToList())
            {
                if (wagon.CheckSizeAndDiet(animal))
                {
                    // if no wagon exists yet, add a new one
                    if (Wagons.Count <= 0)
                    {
                        wagon = new Wagon();
                        Wagons.Add(wagon);
                        wagon.AddAnimal(animal);
                    }
                    else
                    {
                        wagon.AddAnimal(animal);
                    }
                    sortedCarnivores.Remove(animal);
                }
                else
                {
                    wagon = new Wagon();
                    Wagons.Add(wagon);
                    wagon.AddAnimal(animal);
                    sortedCarnivores.Remove(animal);

                }
            }
            AddHerbivoresToWagon();
        }
        private void AddHerbivoresToWagon()
        {
            for (int i = 0; i < sortedHerbivores.Count; ++i)
            {
                foreach (var currWagon in Wagons.ToList())
                {
                    if (currWagon.CheckSizeAndDiet(sortedHerbivores[i]))
                    {
                        currWagon.AddAnimal(sortedHerbivores[i]);
                        sortedHerbivores.Remove(sortedHerbivores[i]);
                    }
                }
                {
                    wagon = new Wagon();
                    Wagons.Add(wagon);
                    wagon.AddAnimal(sortedHerbivores[i]);
                    sortedHerbivores.Remove((sortedHerbivores[i]));
                }
            }
        }
    }
}