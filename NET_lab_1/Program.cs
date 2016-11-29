using System;

namespace NET_lab_1
{
    public class Engine
    {
        public string EngineTank(string forcer, string cylinder)
        {
			string result = forcer + cylinder;
            return result;
        }
    }

    //    public class Transmission
    //    {
    //        public bool clutch(bool cl)
    //        {
    //            return cl;
    //        }
    //        public string gearbox(string gear)
    //        {
				//return gear;
    //        }
    //    }

        public abstract class LeftTrack
        {
            public int lTrack(int l_track)
            {
				return l_track;
            }
            abstract public int rTrack(int r_Track);
        }

		public class RightTrack : LeftTrack
        {
            public override int rTrack(int r_track)
            {
				return r_track;
            }
        }

        public class Weapon
        {
            public string type_weapon(string weapone)
            {
                return weapone;
            }
            public int Number_of_Cartridges(int catridges)
            {
                return catridges;
            }

        }

        public class Tower
        {
            public string weapon(string gun)
            {
                return gun;
            }
        }

        public class TypeTank
        {
            public string type_tank(string type)
            {
				return type;
            }
        }

        public class Control
        {
            public string Moving(string moving)
            {
                return moving;
            }
            public string Shoot(string shoot)
            {
                return shoot;
            }
        }

        public class Country
        {
            public string countryName(string country)
            {
				return country;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Двигатель");
				Engine engine = new Engine();
				RightTrack right_track = new RightTrack();
                Console.WriteLine("Правая гусеница");
                Console.WriteLine("Левая гусеница");
                Weapon weapon = new Weapon();
                Console.WriteLine("Количество снарядов");
				Tower tower = new Tower();
                Console.WriteLine("Башня");
				TypeTank type = new TypeTank();
                Console.WriteLine("Тип танка");
                Control control = new Control();
                Console.WriteLine("Движение танком");
                Console.WriteLine("Стрельба из танка");
				Country country = new Country();
                Console.WriteLine("Страна-производитель");

 
            }
        }
}
