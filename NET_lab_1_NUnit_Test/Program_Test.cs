using NUnit.Framework;
using NET_lab_1;

namespace NET_lab_1_NUnit_Test
{
    [TestFixture]
    public class Program_Test
    {
        [Test]
        public void testEngine()
        {
			Engine engineTest = new Engine();
			string result = engineTest.EngineTank("Поршень ", "Цилиндр");
            Assert.That(result, Is.EqualTo("Поршень Цилиндр"));
        }

        [Test]
        public void testTower()
        {
			Tower towerTest = new Tower();
			string result = towerTest.weapon("2А46М-1");
            Assert.That(result, Is.EqualTo("2А46М-1"));
        }

        [Test]
        public void testType()
        {
			TypeTank typeTest = new TypeTank();
			string result = typeTest.type_tank("Heavy");
            Assert.That(result, Is.EqualTo("Heavy"));
        }

        [Test]
        public void testControl()
        {
            Control lol = new Control();
            string result = lol.Moving("Moving track");
            Assert.That(result, Is.EqualTo("Moving track"));
            string res = lol.Shoot("shoot weapon");
            Assert.That(res, Is.EqualTo("shoot weapon"));
        }

        [Test]
        public void testCountry()
        {
			Country countryTest = new Country();
			string result = countryTest.countryName("Russia");
            Assert.That(result, Is.EqualTo("Russia"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
