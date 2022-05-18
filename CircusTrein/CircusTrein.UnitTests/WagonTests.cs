using CircusTrein.Logic.Models;
using System.Collections.Generic;
using Xunit;

namespace CircusTrein.UnitTests
{
    public class WagonTests
    {
        private readonly Wagon _wagon;

        public WagonTests()
        {
            _wagon = new Wagon();
        }

        [Fact]
        public void WagonDefaultConstructionTest()
        {
            // Assert
            Assert.NotNull(_wagon);
            Assert.Equal(10, _wagon.MaxCapacity);
        }

        // Todo: use enum to let this test pass
        [Fact]
        public void CannotAddMinus()
        {
            // Arrange
            Animal animal = new Herbivore("Deer", -5, "Herbivore");

            // Act
            _wagon.AddAnimal(animal);
            
            int expected = 0;
            int actual = _wagon.animals.Count;
            
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LowerCapacityWhenAnimalAdddedTest()
        {
            // Arrange
            Animal animal = new Herbivore("Deer", 5, "Herbivore");

            int currCapacity = _wagon.Capacity;
            int animalSize = animal.Size;
            int expectedNewCapacity = currCapacity - animalSize;

            // Act
            _wagon.AddAnimal(animal);

            // Assert
            Assert.Equal(expectedNewCapacity, _wagon.Capacity);
        }

        [Fact]
        public void CannotAddAnimalsToFullWagon()
        {
            // Arrange
            List<Animal> animals = new List<Animal>();
            animals.Add(new Herbivore("Deer", 5, "Herbivore"));
            animals.Add(new Herbivore("Deer", 5, "Herbivore"));

            // Act
            animals.Add(new Herbivore("Deer", 1, "Herbivore"));

            foreach (Animal animal in animals)
            {
                if (_wagon.CheckSizeAndDiet(animal) == true)
                {
                    _wagon.AddAnimal(animal);
                }
                else
                {
                    _wagon.AddAnimal(animal);
                }
            }

            // Assert
            Assert.Equal(2, _wagon.WagonNumber);
        }

        [Fact]
        public void CannotAddCarnivoreToHerbivoreTest()
        {
            // Arrange
            List<Animal> animals = new List<Animal>();
            animals.Add(new Herbivore("Deer", 5, "Herbivore"));

            // Act
            animals.Add(new Carnivore("Lion", 5, "Carnivore"));

            foreach (Animal animal in animals)
            {
                if (_wagon.CheckSizeAndDiet(animal) == true)
                {
                    _wagon.AddAnimal(animal);
                }
                else
                {
                    _wagon.AddAnimal(animal);
                }
            }

            // Assert
            Assert.Equal(1, _wagon.WagonNumber);
        }
    }
}