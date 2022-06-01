using CircusTrein.Logic.Enums;

namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        public int animalPoints;
        public List<Animal> animals = new List<Animal>();
        public Size size = new Size();
        public int WagonNumber { get; internal set; }
        public int MaxCapacity { get; private set; }
        public int Capacity { get; private set; }

        public Wagon()
        {
            animals = new List<Animal>();
            WagonNumber = 1;
            MaxCapacity = 10;
            Capacity = 10;
        }

        public bool CheckSizeAndDiet(Animal animal)
        {
            Console.WriteLine("Check size and diet aangeroepen");
            // Check capacity and if the animal is eatable
            if (CheckCapacity(animal.Size) && !IsEatable(animal))
            {
                return true;
            }
            return false;
        }

        public bool CheckCapacity(int size)
        {
            // Check capacity
            if (animalPoints + size <= MaxCapacity)
            {
                return true;
            }
            WagonNumber++;
            return false;
        }

        public bool IsEatable(Animal animal)
        {
            foreach (var animalInwagon in animals)
            {
                if (animalInwagon.Size == 5 && animalInwagon.GetType() == typeof(Carnivore))
                {
                    return true;
                }
                if (animal.Size > animalInwagon.Size && animal.GetType() == typeof(Herbivore))
                {
                    return false;
                }
                if (animal.GetType() == typeof(Herbivore) && animalInwagon.GetType() == typeof(Carnivore) && animal.Size <= animalInwagon.Size)
                {
                    return true;
                }
                if (animal.Size == animalInwagon.Size && animalInwagon.GetType() == typeof(Herbivore) && animal.GetType() == typeof(Herbivore))
                {
                    return false;
                }
                if (animalInwagon.Size > animal.Size && animal.GetType() == typeof(Carnivore))
                {
                    return true;
                }
                if (animal.Size >= animalInwagon.Size)
                {
                    return true;
                }
            }
            return false;

        }

        public bool AddAnimal(Animal animal)
        {
            bool animalIsEatable = IsEatable(animal);
            if (animalIsEatable == false)
            {
                animalPoints += animal.Size;
                Capacity -= animalPoints;
                animals.Add(animal);
                return true;
            }
            Capacity -= animalPoints;
            WagonNumber++;
            return false;
        }
    }
}
