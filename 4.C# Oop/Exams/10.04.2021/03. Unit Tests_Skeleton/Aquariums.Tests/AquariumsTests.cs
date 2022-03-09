namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class AquariumsTests
    {

        private string name;
        private int capacity;
        private Aquarium aquarium;
        private Fish fish;

        [SetUp]
        public void StartUp()
        {
            this.name = "Pesho";
            this.capacity = 30;
            this.aquarium = new Aquarium(name, capacity);
            this.fish = new Fish("Gosho");
        }

        [Test]
        public void Should_ReturnTheName_When_Asked()
        {

            Assert.That(aquarium.Name, Is.EqualTo(name));
        }

        [Test]
        public void Should_ThrowException()
        {

            Assert.Throws<ArgumentNullException>(() =>
            {
                aquarium = new Aquarium(string.Empty, capacity);
            });
        }

        [Test]
        public void Should_ReturnTheCapacity_WhenAsked()
        {

            Assert.That(aquarium.Capacity, Is.EqualTo(capacity));
        }

        [Test]
        public void Should_ThrowException2()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                aquarium = new Aquarium(this.name, -1);
            });
        }

        [Test]
        public void Should_AddFish()
        {
            aquarium.Add(fish);
            Assert.That(aquarium.Count, Is.EqualTo(1));
        }

        [Test]
        public void Should_SellaFish()
        {
            aquarium.Add(fish);
            Assert.That(aquarium.SellFish("Gosho"), Is.EqualTo(fish));
            
        }

        public void Should_RemoveAFish()
        {
            aquarium.Add(fish);
            aquarium.RemoveFish("Gosho");
            Assert.That(aquarium.Count, Is.EqualTo(0));

        }

        public void Should_Throw3()
        {
            aquarium.Add(fish);
            Assert.Throws<InvalidOperationException>(() => {
                aquarium.SellFish("Gosho"); 
                });

        }

        public void Should_Throw4()
        {
            aquarium.Add(fish);
            Assert.Throws<InvalidOperationException>(() => {
                aquarium.RemoveFish("Gosho");
            });

        }

        public void Should_return_report()
        {
            aquarium.Add(fish);
           
            Assert.That(aquarium.Report, Is.EqualTo("Pesho"));

        }


    }
}
