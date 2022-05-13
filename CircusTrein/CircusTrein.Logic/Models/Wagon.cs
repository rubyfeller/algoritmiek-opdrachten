namespace CircusTrein.Logic.Models
{
    public class Wagon
    {
        public int animalPoints;
        public List<Carnivore> carnivores;
        public List<Herbivore> herbivores;

        public int WagonNumber { get; internal set; }

        public Wagon()
        {
            carnivores = new List<Carnivore>();
            herbivores = new List<Herbivore>();
        }

        public bool CheckSizeAndDiet(Carnivore carnivore)
        {
            // Check capacity and wether the animal is eatable
            if (CheckCapacity(carnivore.Size) && !IsEatable(carnivore))
            {
                //Console.WriteLine("Size and diet are correct");
                return true;
            }
            //Console.WriteLine("Size or diet not correct");
            return false;
        }

        public bool CheckCapacity(int size)
        {
            // Check capacity
            if (animalPoints + size <= 10)
            {
                //Console.WriteLine("Capacity is correct");
                return true;
            }
            //Console.WriteLine("Capacity is not correct");
            return false;
        }


        public bool IsEatable(Carnivore carnivore)
        {
            foreach (Carnivore currCarnivore in carnivores)
            {
                if (carnivore.Diet == "Carnivore")
                {
                    // Animal size must be smaller or the same as the current animal in order to be eaten
                    if (carnivore.Size <= currCarnivore.Size)
                    {
                        //Console.WriteLine("Animal is eatable");
                        return true;
                    }
                }
                if (currCarnivore.Diet == "Carnivore")
                {
                    if (currCarnivore.Size >= carnivore.Size)
                    {
                        //Console.WriteLine("Animal is eatable");
                        return true;
                    }
                }
                //foreach (Herbivore currHerbivore in herbivores)
                //{
                //    if (herbivore.Diet == "Herbivore")
                //    {
                //        // Animal size must be smaller or the same as the current animal in order to be eaten
                //        if (currHerbivore.Size <= currCarnivore.Size)
                //        {
                //            //Console.WriteLine("Animal is eatable");
                //            return true;
                //        }
                //    }
                //    if (currHerbivore.Diet == "Herbivore")
                //    {
                //        if (herbivore.Size >= carnivore.Size)
                //        {
                //            //Console.WriteLine("Animal is eatable");
                //            return true;
                //        }
                //    }
            }
            return false;

        }

        public bool AddCarnivore(Carnivore newCarnivore)
        {
            animalPoints += newCarnivore.Size;
            return true;
        }

        public bool AddHerbivore(Herbivore newHerbivore)
        {
            animalPoints += newHerbivore.Size;
            return true;
        }
    }
}
