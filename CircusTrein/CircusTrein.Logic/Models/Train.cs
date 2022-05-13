namespace CircusTrein.Logic.Models
{
    public class Train
    {

        public Train()
        {
            Carnivores = new List<Carnivore>();
            Herbivores = new List<Herbivore>();
            Wagons = new List<Wagon>();
        }

        public List<Carnivore> Carnivores { get; }
        public List<Herbivore> Herbivores { get; }
        public List<Wagon> Wagons { get; }

        public void AddAnimalsToWagon()
        {
            Herbivores.Add(new Herbivore("Deer", 5, "Herbivore"));
            Herbivores.Add(new Herbivore("Rabbits", 1, "Herbivore"));
            Carnivores.Add(new Carnivore("Cat", 3, "Carnivore"));
            Carnivores.Add(new Carnivore("Cat", 3, "Carnivore"));
            Carnivores.Add(new Carnivore("Lion", 5, "Carnivore"));


            foreach (var carnivore in Carnivores)
            {
                    Wagon wagon = new Wagon();

                    if (wagon.CheckSizeAndDiet(carnivore) == true)
                    {
                        Console.WriteLine("Wagon" + wagon.WagonNumber + "Animal" + carnivore.Name);
                        wagon.AddCarnivore(carnivore);
                        //wagon.AddHerbivore(herbivore);
                    }
                    else
                    {
                        Console.WriteLine("Carnivore can not be added to wagon");
                        wagon.WagonNumber++;
                        wagon.AddCarnivore(carnivore);
                        //wagon.AddHerbivore(herbivore);
                        Console.WriteLine("Wagon" + wagon.WagonNumber + "Animal" + carnivore.Name);
                    }
                    Wagons.Add(wagon);
                }
            }
        }
    }
