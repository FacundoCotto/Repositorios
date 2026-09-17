using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
    [TestFixture]
    public class MoviesCatalogTests
    {
        private Repository<Movie> moviesCatalog;

        [SetUp]
        public void SetUp()
        {
            this.moviesCatalog = new Repository<Movie>();
        }

        [Test]
        public void Add_ValidMovie_MovieIsFound()
        {
            Movie movie = new Movie("Inception", 2010);

            this.moviesCatalog.Add(movie);

            Movie found = this.moviesCatalog.Find(m => m.Name == "Inception");
            Assert.That(found, Is.SameAs(movie));
        }

        [Test]
        public void Add_NullMovie_MovieIsNotAdded()
        {
            this.moviesCatalog.Add(null);

            Movie found = this.moviesCatalog.Find(m => m == null);
            Assert.That(found, Is.Null);
        }

        [Test]
        public void Remove_ExistingMovie_MovieIsNoLongerFound()
        {
            Movie movie = new Movie("The Matrix", 1999);
            this.moviesCatalog.Add(movie);

            this.moviesCatalog.Remove(movie);

            Movie found = this.moviesCatalog.Find(m => m.Name == "The Matrix");
            Assert.That(found, Is.Null);
        }

        [Test]
        public void Find_MatchingCriteria_ReturnsMovie()
        {
            Movie movie = new Movie("Interstellar", 2014);
            this.moviesCatalog.Add(movie);

            Movie found = this.moviesCatalog.Find(m => m.Year == 2014);

            Assert.That(found, Is.SameAs(movie));
        }

        [Test]
        public void Find_NoMatchingCriteria_ReturnsNull()
        {
            Movie movie = new Movie("Dunkirk", 2017);
            this.moviesCatalog.Add(movie);

            Movie found = this.moviesCatalog.Find(m => m.Name == "Tenet");

            Assert.That(found, Is.Null);
        }

        [Test]
        public void Find_EmptyCatalog_ReturnsNull()
        {
            Movie found = this.moviesCatalog.Find(m => true);

            Assert.That(found, Is.Null);
        }
    }
}
