using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Наследование и полиморфизм в C#

            //Наследовать могут только классы и только от одного базового класа, но от нескольких интерфейсов
            //Структуры наследовать не могут.
            //Все классы неявно являются наследниками System.Object

            TransportShip transportShip = new TransportShip();
            Console.WriteLine("Наследный класс использует метод Move базового класса " + transportShip.Move(1000));
            Console.ReadLine();

            //Разбор передачи парамтреов в базовые и наследные классы
            TransportCar transportCar = new TransportCar();
            Console.WriteLine("В базовый конструктор передан 0");

            TransportCar transportCarPar = new TransportCar(2);
            Console.WriteLine("В базовый конструктор переданa 1");

            TransportCar transportCarPar1 = new TransportCar(2, 3);
            Console.ReadLine();

            //Переопределяемые методы
            BaseShip baseShip = new BaseShip();
            BaseShip ship = new TransportShip(); //так можно

            baseShip.Start();
            ship.Start();
            Console.ReadLine();


        }
    }
}
