using CircusTrein.Logic.Enums;

namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        public int animalPoints;
        public List<Animal> animals = new List<Animal>();
        public Size size = new Size();
        public int MaxCapacity { get; private set; }
        public int Capacity { get; private set; }

        public Wagon()
        {
            animals = new List<Animal>();
            MaxCapacity = 10;
            Capacity = 10;
        }

        public bool CheckSizeAndDiet(Animal animal)
        {
            if (CheckCapacity(animal.Size) && !IsEatable(animal))
            {
                return true;
            }
 
            return false;
        }

        private bool CheckCapacity(int size)
        {
            // Check capacity
            if (animalPoints + size <= Capacity)
            {
                return true;
            }
            return false;
        }

        private bool IsEatable(Animal animal)
        {
            foreach (var animalInwagon in animals)
            {
                if (animal.GetType() == typeof(Herbivore) && animalInwagon.GetType() == typeof(Herbivore))
                {
                    return false;
                }
                if (animalInwagon.GetType() == typeof(Carnivore) && animal.GetType() == typeof(Herbivore) && animal.Size <= animalInwagon.Size)
                {
                    return true;
                }
                if (animal.GetType() == typeof(Herbivore) && animalInwagon.GetType() == typeof(Carnivore) && animal.Size > animalInwagon.Size)
                {
                    return false;
                }
                if (animal.Size <= animalInwagon.Size && animal.GetType() == typeof(Carnivore))
                {
                    return true;
                }
                if (animal.Size <= animalInwagon.Size && animal.GetType() == typeof(Herbivore))
                {
                    return false;
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
                animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
