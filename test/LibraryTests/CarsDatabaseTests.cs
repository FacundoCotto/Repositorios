using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
    [TestFixture]
    public class CarsDatabaseTests
    {
        private CarsDatabase database;

        [SetUp]
        public void SetUp()
        {
            this.database = new CarsDatabase();
        }

        [Test]
        public void AddCar_ValidCar_CarIsFound()
        {
            Car car = new Car("Jimny", "Suzuki", 2024);

            this.database.Add(car);

            Car found = this.database.Find(c => c.Model == "Jimny");
            Assert.That(found, Is.SameAs(car));
        }

        [Test]
        public void AddCar_NullCar_CarIsNotAdded()
        {
            this.database.Add(null);

            Car found = this.database.Find(c => c == null);
            Assert.That(found, Is.Null);
        }

        [Test]
        public void RemoveCar_ExistingCar_CarIsNoLongerFound()
        {
            Car car = new Car("Focus", "Ford", 2018);
            this.database.Add(car);

            this.database.Remove(car);

            Car found = this.database.Find(c => c.Model == "Focus");
            Assert.That(found, Is.Null);
        }

        [Test]
        public void FindCar_MatchingCriteria_ReturnsCar()
        {
            Car car = new Car("Onix", "Chevrolet", 2022);
            this.database.Add(car);

            Car found = this.database.Find(c => c.Year == 2022);

            Assert.That(found, Is.SameAs(car));
        }

        [Test]
        public void FindCar_NoMatchingCriteria_ReturnsNull()
        {
            Car car = new Car("Sandero", "Renault", 2015);
            this.database.Add(car);

            Car found = this.database.Find(c => c.Model == "Duster");

            Assert.That(found, Is.Null);
        }

        [Test]
        public void FindCar_EmptyDatabase_ReturnsNull()
        {
            Car found = this.database.Find(c => true);

            Assert.That(found, Is.Null);
        }
    }
}
