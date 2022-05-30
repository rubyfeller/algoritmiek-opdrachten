using CircusTrein.Logic.Enums;

namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        public int animalPoints;
        public List<Animal> animals = new List<Animal>();
        public Size size = new Size();
        public int WagonNumber { get; internal set; }
        public int MaxCapacity { get; internal set; }
        public int Capacity { get; internal set; }


        public Wagon()
        {
            animals = new List<Animal>();
            WagonNumber = 1;
            MaxCapacity = 10;
            Capacity = 10;
        }

        public List<Wagon> GetWagons()
        {
            Train train = new Train();
            return train.Wagons;
        }

        public bool CheckSizeAndDiet(Animal animal)
        {
            Console.WriteLine("Check size and diet aangeroepen");
            // Check capacity and wether the animal is eatable
            if (CheckCapacity(animal.Size) && !IsEatable(animal))
            {
                //Capacity -= animal.Size;
                return true;
            }
            return false;
        }

        public bool CheckCapacity(int size)
        {
            // Check capacity
            if (animalPoints + size <= MaxCapacity)
            {
                //Capacity -= animalPoints + size;

                return true;
            }
            WagonNumber++;
            return false;
        }

        public bool IsEatable(Animal animal)
        {
            foreach (var animalInwagon in animals)
            {
                if (animalInwagon.Size == 5 && animalInwagon.Diet == "Carnivore")
                {
                    return true;
                }
                if (animal.Size > animalInwagon.Size && animal.Diet == "Herbivore")
                {
                    return false;
                }
                if (animal.Size == animalInwagon.Size && animalInwagon.Diet == "Herbivore" && animal.Diet == "Herbivore")
                {
                    return false;
                }
                if (animal.Size >= animalInwagon.Size)
                {
                    return true;
                }
            }
            return false;

        }

        public bool IsAnimalInWagonEatable(Animal animal)
        {
            foreach (var animalInwagon in animals)
            {
                if (animal.Size > animalInwagon.Size && animal.Diet == "Herbivore")
                {
                    return false;
                }
                if (animal.Size == animalInwagon.Size && animalInwagon.Diet == "Herbivore" && animal.Diet == "Herbivore")
                {
                    return false;
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
            //bool placedAnimalIsEatable = IsAnimalInWagonEatable(animal);
            bool animalIsEatable = IsEatable(animal);
            if (animalIsEatable == false)
            {
                animalPoints += animal.Size;
                Capacity -= animalPoints;
                animals.Add(animal);
                return true;
            }
            WagonNumber++;
            return false;
        }
    }
}
