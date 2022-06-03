using CircusTrein.Logic.Models;
using System.Collections.Generic;
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
        public void CannotAddMinusTest()
        {
            bool exception = false;

            // Act
            try
            {
                Animal animal = new Herbivore("Deer", -5, "Herbivore");
                _wagon.AddAnimal(animal);

            }
            catch (System.Exception)
            {
                exception = true;
            }

            // Assert
            Assert.True(exception);
        }

        [Fact]
        public void CannotAddIncorrectSpeciesTest()
        {
            bool exception = false;

            // Act
            try
            {
                Animal animal = new Carnivore("Deer", 5, "Omnivore");
                _wagon.AddAnimal(animal);

            }
            catch (System.Exception)
            {
                exception = true;
            }

            // Assert
            Assert.True(exception);
        }

        [Fact]
        public void CannotAddAnimalsToFullWagon()
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
        }

        [Fact]
        public void CannotAddEqualCarnivoreToHerbivoreTest()
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
        }

        [Fact]
        public void CannotAddBiggerCarnivoreToSmallerHerbivore()
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
        }

        [Fact]
        public void CannotAddEqualCarnivores()
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
        }
    }
}