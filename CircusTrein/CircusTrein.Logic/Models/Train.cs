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

        public void AddAnimals(List<Animal> animals)
        {
            Animals = animals;

            carnivores = FilterCarnivores();
            herbivores = FilterHerbivores();
            AddAnimalsToTheWagon();

        }
        private List<Animal> FilterCarnivores()
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

        private List<Animal> FilterHerbivores()
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

        //public void AddAnimalsToTheWagenRefactored()
        //{
        //    foreach (Animal animal in Animals.ToList())
        //    {
        //        if (wagon.CheckSizeAndDiet(animal) == true)
        //        {
        //            if (Wagons.Count == 0)
        //            {
        //                wagon = new Wagon();
        //                Wagons.Add(wagon);
        //                wagon.WagonNumber++;
        //                wagon.AddAnimal(animal);
        //            }
        //            else
        //            {
        //                wagon.AddAnimal(animal);
        //            }
        //            //Animals.Remove(animal);
        //        }
        //        else
        //        {
        //            wagon = new Wagon();
        //            Wagons.Add(wagon);
        //            wagon.WagonNumber++;
        //            wagon.AddAnimal(animal);
        //            //Animals.Remove(animal);
        //        }
        //    }
        //}

        private void AddAnimalsToTheWagon()
        {
            foreach (var carnivore in carnivores.ToList())
            {
                if (wagon.CheckSizeAndDiet(carnivore))
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
                    if (wagon.CheckSizeAndDiet(herbivore))
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
    }
}