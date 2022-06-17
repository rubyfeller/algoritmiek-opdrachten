using CircusTrein.Logic.Enums;

namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        public int animalPoints;
        private List<Animal> Animals { get; }
        public Size size = new Size();
        public int MaxCapacity { get; }
        private int Capacity { get; }

        public Wagon()
        {
            Animals = new List<Animal>();
            MaxCapacity = 10;
            Capacity = 10;
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return Animals.AsEnumerable();
        }

        public bool CheckSizeAndDiet(Animal animal)
        {
            return CheckCapacity(animal.Size) && !IsEatable(animal);
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
            foreach (var animalInwagon in Animals)
            {
                if (animal.GetType() == typeof(Herbivore) && animalInwagon.GetType() == typeof(Herbivore)
                    && animal.Size <= animalInwagon.Size)
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
            }

            return false;
        }

        public bool AddAnimalToWagon(Animal animal)
        {
            bool animalIsEatable = IsEatable(animal);
            bool animalFits = CheckCapacity(animal.Size);

            if (animalIsEatable == false && animalFits == true)
            {
                animalPoints += animal.Size;
                Animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
