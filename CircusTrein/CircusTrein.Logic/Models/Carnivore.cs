namespace CircusTrein.Logic.Models
{
    // Eats meat
    public class Carnivore : Animal
    {
        public Carnivore(string name, int size, string diet) : base(name, size, diet)
        {
        }
        public override bool DoesAnimalEat()
        {
            return true;
        }
    }
}