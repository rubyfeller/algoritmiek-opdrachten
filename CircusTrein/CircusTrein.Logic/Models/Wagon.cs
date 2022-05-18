namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        public int animalPoints;
        public List<Animal> animals = new List<Animal>();

        public int WagonNumber { get; internal set; }
        public int MaxCapacity { get; internal set; }
        public int Capacity { get; internal set; }


        public Wagon()
        {
            animals = new List<Animal>();
            WagonNumber = 0;
            MaxCapacity = 10;
            Capacity = 0;
        }

        public bool CheckSizeAndDiet(Animal animal)
        {
            // Check capacity and wether the animal is eatable
            if (CheckCapacity(animal.Size) && IsEatable(animal))
            {
                Capacity -= animal.Size;
                return true;
            }
            WagonNumber++;
            return false;
        }

        public bool CheckCapacity(int size)
        {
            // Check capacity
            if (animalPoints + size <= MaxCapacity)
            {
                Capacity -= animalPoints + size;
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
            Capacity -= animalPoints;
            animals.Add(animal);
            return true;
        }
    }
}
