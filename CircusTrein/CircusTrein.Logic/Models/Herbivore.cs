namespace CircusTrein.Logic.Models
{
    // Does not eat meat
    public class Herbivore : Animal
    {
        public Herbivore(string name, int size, string diet) : base(name, size, diet)
        {
        }
        public override bool DoesAnimalEat()
        {
            return false;
        }
    }
}