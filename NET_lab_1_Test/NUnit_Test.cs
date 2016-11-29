using NUnit.Framework;
using NET_lab_1;


namespace NET_lab_1_Test
{
    public class NUnit_Test
    {
        [Test]
        public void Test_Menu()
        {
            Menu lol = new Menu();
            string result = lol.Menu_NewGame_Setting_Exit("Новая игра ", "Настройки ", "Выход");
            //Assert.AreEqual("Новая игра Настройки Выход", result);
            Assert.That(result, Is.EqualTo("Новая игра Настройки Выход"));
        }

        [Test]
        public void Test_Enemy()
        {
            Enemys lol = new Enemys();
            string result = lol.AI_enemy("Normal");
            Assert.That(result, Is.EqualTo("Normal"));
        }

        [Test]
        public void Test_Graphic()
        {
            Graphic lol = new Graphic();
            string result = lol.type_Graphic("Pixel");
            Assert.That(result, Is.EqualTo("Pixel"));
        }

        [Test]
        public void Test_Conrol()
        {
            Control lol = new Control();
            string result = lol.Moving("W,A,S,D");
            Assert.That(result, Is.EqualTo("W,A,S,D"));
            string res = lol.Shoot("Left Click");
            Assert.That(res, Is.EqualTo("Left Click"));
        }

        [Test]
        public void Test_Name_Map()
        {
            Name_Map lol = new Name_Map();
            string result = lol.N_Map("Temple");
            Assert.That(result, Is.EqualTo("Temple"));
        }
    }
}
