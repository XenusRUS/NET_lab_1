using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET_lab_1;

namespace NET_lab_1_Test
{
    [TestClass]
    public class Program_Test
    {
        [TestMethod]
        public void Test_Menu()
        {
            Menu lol = new Menu();
            string result = lol.Menu_NewGame_Setting_Exit("Новая игра ", "Настройки ", "Выход");
            Assert.AreEqual("Новая игра Настройки Выход", result);
        }

        [TestMethod]
        public void Test_Min_Map()
        {
            Min_Map lol = new Min_Map();
            bool res = lol.Enemy(true);
            Assert.AreEqual(true, res);
            string result = lol.landscape("Rovno");
            Assert.AreEqual("Rovno", result);
        }

        [TestMethod]
        public void Test_Heal_Point()
        {
            Heal_Point lol = new Stamina_Point();
            int res = lol.H_Point(100);
            int result = lol.S_Point(100);
            Assert.AreEqual(100, res);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Test_Weapon()
        {
            Weapon lol = new Weapon();
            string res = lol.type_weapon("M16");
            int result = lol.Number_of_Cartridges(35);
            Assert.AreEqual("M16", res);
            Assert.AreEqual(35, result);
        }
    }
}
