using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    //Створити суперклас Судно і підкласи Вантажний Корабель, Танкер, Катер. За допомогою конструктора задати швидкість кожного засобу.
    //Визначити грузопідйомність у всіх вантажних типах суден. Вивести на екран тип пального, яке використовує сyдно. Реалізувати функцію дозаправки суден.
    class Program
    {
        static void Main(string[] args)
        {
            CargoShip csh = new CargoShip(548, "Cargo Ship", "F56");
            csh.CarryingCapacity(2200);
            csh.GetPalevo(89);
            Tanker tn = new Tanker(786, "Tanker", "G52");
            tn.CarryingCapacity(1230);
            tn.GetPalevo1(74);
            Cutter ct = new Cutter(236, "Cutter", "H50");
            ct.GetPalevo2(51);
        }
    }
    abstract class Ship
    {
        public int Speed;
        public string Fuel;
        public Ship(int speed, string fuel)
        {
            this.Fuel = fuel;
            this.Speed = speed;
            Console.WriteLine("Averedge speed: " + speed);
        }
    }
    class CargoShip: Ship
    {
        public string Name;
        public CargoShip(int speed, string name, string fuel)
            :base(speed, fuel)
        {
            this.Name = name;
            Console.WriteLine("Name of ship: {0};\t Ship's speed: {1}", name, speed);
            Console.WriteLine("Type of fuel:" + fuel);
        }
        public void CarryingCapacity(int masa)
        {
            Console.WriteLine("Carrying capacity of CargoShip: {0}" , masa);
        }
        public void GetPalevo(int fuel1)
        {
            if(fuel1 < 100)
            {
                Console.WriteLine("Little fuel!");
                Console.WriteLine("Refueling required!!!");
                Console.WriteLine("Enter the number of liters required for prefilling: ");
                int a = int.Parse(Console.ReadLine());
                int meg = fuel1 + a;
                Console.WriteLine("Refueling: " + meg);
            }
        }
    }
    class Tanker : Ship
    {
        public string Name;
        public Tanker(int speed, string name, string fuel)
            : base(speed, fuel)
        {
            this.Name = name;
            Console.WriteLine("Name of ship: {0};\t Ship's speed: {1}", name, speed);
            Console.WriteLine("Type of fuel:" + fuel);
        }
        public void CarryingCapacity(int masa)
        {
            Console.WriteLine("Carrying capacity of Tanker: {0}" , masa);
        }
        public void GetPalevo1(int fuel2)
        {
            if (fuel2 < 80)
            {
                Console.WriteLine("Little fuel!");
                Console.WriteLine("Refueling required!!!");
                Console.WriteLine("Enter the number of liters required for prefilling: ");
                int b = int.Parse(Console.ReadLine());
                int meb = fuel2 + b;
                Console.WriteLine("Refueling: " + meb);
            }
        }
    }
    class Cutter: Ship
    {
        public string Name;
        public Cutter(int speed, string name, string fuel)
            : base(speed, fuel)
        {
            this.Name = name;
            Console.WriteLine("Name of ship: {0};\t Ship's speed: {1}", name, speed);
            Console.WriteLine("Type of fuel:" + fuel);
        }
        public void GetPalevo2(int fuel3)
        {
            if (fuel3 < 50)
            {
                Console.WriteLine("Little fuel!");
                Console.WriteLine("Refueling required!!!");
                Console.WriteLine("Enter the number of liters required for prefilling: ");
                int c = int.Parse(Console.ReadLine());
                int mek = fuel3 + c;
                Console.WriteLine("Refueling: " + mek);
            }
        }
    }
}
