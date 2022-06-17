using CircusTrein.Logic.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CircusTrein.UnitTests
{
    public class CircusTrainTests
    {
        private readonly Wagon _wagon;

        public CircusTrainTests()
        {
            _wagon = new Wagon();
        }

        [Fact]
        public void TestCannotAddMinus()
        {
            bool exception = false;

            // Act
            try
            {
                Animal animal = new Herbivore("Deer", -5, "Herbivore");
                _wagon.AddAnimalToWagon(animal);

            }
            catch (System.Exception)
            {
                exception = true;
            }

            // Assert
            Assert.True(exception);
        }

        [Fact]
        public void TestCannotAddIncorrectSpecies()
        {
            bool exception = false;

            // Act
            try
            {
                Animal animal = new Carnivore("Deer", 5, "Omnivore");
                _wagon.AddAnimalToWagon(animal);

            }
            catch (System.Exception)
            {
                exception = true;
            }

            // Assert
            Assert.True(exception);
        }

        [Fact]
        public void TestAnimalPointsAreUpdatedWhenAnimalIsAdded()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();

            // Act
            animals.Add(new Carnivore("Lion", 1, "Carnivore"));

            train.AddAnimals(animals);

            int wagonsAmount = train.Wagons.Count;
            int animalPoints = train.Wagons[0].animalPoints;

            // Assert
            Assert.Equal(1, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
            Assert.Equal(1, animalPoints);
        }

        [Fact]
        public void TestCannotAddAnimalsToFullWagon()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Herbivore("Deer", 5, "Herbivore"));
            animals.Add(new Herbivore("Deer", 5, "Herbivore"));

            // Act
            animals.Add(new Carnivore("Lion", 1, "Carnivore"));

            train.AddAnimals(animals);

            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(2, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        [Fact]
        public void TestCannotAddEqualCarnivoreToHerbivoreTest()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Herbivore("Deer", 5, "Herbivore"));

            // Act
            animals.Add(new Carnivore("Lion", 5, "Carnivore"));

            train.AddAnimals(animals);
            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(2, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        [Fact]
        public void TestCannotAddBiggerCarnivoreToSmallerHerbivore()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Herbivore("Deer", 1, "Herbivore"));

            // Act
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));


            train.AddAnimals(animals);
            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(2, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        [Fact]
        public void TestCannotAddEqualCarnivores()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));

            // Act
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));

            train.AddAnimals(animals);

            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(2, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        [Fact]
        public void Test39AnimalsResultIn16Wagons()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();

            // Act
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));

            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));

            animals.Add(new Carnivore("Tiger", 5, "Carnivore"));
            animals.Add(new Carnivore("Tiger", 5, "Carnivore"));

            animals.Add(new Carnivore("Lion", 3, "Carnivore"));
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));
            animals.Add(new Carnivore("Lion", 3, "Carnivore"));

            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));

            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));

            train.AddAnimals(animals);

            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(16, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        [Fact]
        public void Test6AnimalsResultIn2Wagons()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();

            // Act
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));

            train.AddAnimals(animals);

            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(2, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        [Fact]
        public void Test10Herbivores2CarnivoresResultIn4Wagons()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();

            // Act
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 5, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 3, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 3, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 3, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 3, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 3, "Herbivore"));
            animals.Add(new Herbivore("Rabbit", 3, "Herbivore"));
            animals.Add(new Carnivore("Rabbit", 1, "Carnivore"));
            animals.Add(new Carnivore("Rabbit", 1, "Carnivore"));


            train.AddAnimals(animals);

            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(4, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        [Fact]
        public void Test39AnimalsResultIn13Wagons()
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();

            // Act
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));
            animals.Add(new Carnivore("Bear", 1, "Carnivore"));


            animals.Add(new Herbivore("Buffalo", 5, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 5, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 5, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 5, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 5, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 5, "Herbivore"));

            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 1, "Herbivore"));

            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));
            animals.Add(new Herbivore("Buffalo", 3, "Herbivore"));


            train.AddAnimals(animals);

            int wagonsAmount = train.Wagons.Count;

            // Assert
            Assert.Equal(13, wagonsAmount);
            Assert.Equal(animals.Count, GetAnimalsInWagons(train.Wagons));
        }

        private int GetAnimalsInWagons(List<Wagon> wagons)
        {
            int animalsInWagonAmount = 0;
            foreach (var currWagon in wagons)
            {
                animalsInWagonAmount += currWagon.GetAnimals().Count();
            }
            return animalsInWagonAmount;
        }
    }
}