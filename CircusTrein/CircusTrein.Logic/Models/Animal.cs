namespace CircusTrein.Logic.Models
{
    // Base class
    public abstract class Animal
    {

        public Animal(string name, int size, string diet)
        {
            Name = name;
            if (size > 0)
            {
                Size = size;
            }
            else
            {
                throw new ArgumentException("Size must be greater than 0");
            }

            if (diet == "Carnivore" || diet == "Herbivore")
            {
                Diet = diet;
            }
            else
            {
                throw new ArgumentException("Diet must be Carnivore or Herbivore");
            }
        }

        public abstract bool DoesAnimalEat();

        public string Name { get; }
        public int Size { get; }
        public string Diet { get; }
    }
}
