namespace CircusTrein.Logic.Models
{
    // Base class
    public class Animal
    {

        public Animal(string name, int size, string diet)
        {
            Name = name;
            Size = size;
            Diet = diet;
        }

        public string Name { get; set; }
        public int Size { get; set; }
        public string Diet { get; set; }
    }
}
