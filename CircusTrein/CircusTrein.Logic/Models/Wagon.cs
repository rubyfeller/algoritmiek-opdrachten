namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        public int animalPoints;
        public List<Carnivore> carnivores;
        public List<Herbivore> herbivores;
        public List<Animal> animals = new List<Animal>();


        public int WagonNumber { get; internal set; }

        public Wagon()
        {
            carnivores = new List<Carnivore>();
            herbivores = new List<Herbivore>();
            animals = new List<Animal>();

        }

        public bool CheckSizeAndDiet(Animal animal)
        {
            // Check capacity and wether the animal is eatable
            if (CheckCapacity(animal.Size) && IsEatable(animal))
            {
                return true;
            }
            return false;
        }

        public bool CheckCapacity(int size)
        {
            // Check capacity
            if (animalPoints + size <= 10)
            {
                return true;
            }
            return false;
        }


        public bool IsEatable(Animal animal)
        {
            foreach (Animal currAnimal in animals)
            {
                if (animal.Diet == "Herbivore")
                {
                    // Animal size must be smaller or the same as the current animal in order to be eaten
                    if (animal.Size <= currAnimal.Size)
                    {
                        return true;
                    }
                }
                if (animal.Diet == "Herbivore")
                {
                    if (animal.Size >= animal.Size)
                    {
                        return true;
                    }
                }
                if (animal.Diet == "Carnivore")
                {
                    // Animal size must be smaller or the same as the current animal in order to be eaten
                    if (animal.Size <= currAnimal.Size)
                    {
                        return true;
                    }
                }
                if (animal.Diet == "Carnivore")
                {
                    if (animal.Size >= animal.Size)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool AddAnimal(Animal animal)
        {
            animalPoints += animal.Size;
            animals.Add(animal);
            return true;
        }
    }
}
