using CircusTrein.Logic.Enums;

namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        private int animalPoints;

        private List<Animal> Animals { get; }
        public int Capacity { get; }

        public Wagon()
        {
            Animals = new List<Animal>();
            Capacity = 10;
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return Animals.AsEnumerable();
        }

        public int GetAnimalPoints()
        {
            return animalPoints;
        }

        public bool CheckSizeAndDiet(Animal animal)
        {
            return CheckCapacity(animal.Size) && !IsEdible(animal);
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

        private bool IsEdible(Animal animal)
        {
            foreach (var animalInwagon in Animals)
            {
                if (animal.DoesAnimalEat() == false
                    && animalInwagon.DoesAnimalEat() == false
                    && animal.Size <= animalInwagon.Size)
                {
                    return false;
                }
                if (animalInwagon.DoesAnimalEat()
                    && animal.DoesAnimalEat() == false
                    && animal.Size <= animalInwagon.Size)
                {
                    return true;
                }
                if (animal.DoesAnimalEat() == false
                    && animalInwagon.DoesAnimalEat() == true
                    && animal.Size > animalInwagon.Size)
                {
                    return false;
                }
                if (animal.Size <= animalInwagon.Size
                    && animal.DoesAnimalEat())
                {
                    return true;
                }
            }

            return false;
        }

        public bool AddAnimalToWagon(Animal animal)
        {
            bool animalIsEdible = IsEdible(animal);
            bool animalFits = CheckCapacity(animal.Size);

            if (animalIsEdible == false && animalFits == true)
            {
                animalPoints += animal.Size;
                Animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
