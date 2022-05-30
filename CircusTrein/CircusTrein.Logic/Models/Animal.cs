namespace CircusTrein.Logic.Models
{
    // Base class
    public class Animal
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

        public string Name { get; set; }
        public int Size { get; set; }
        public string Diet { get; set; }
    }
}
