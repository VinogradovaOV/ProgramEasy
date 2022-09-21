using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson5
{
    class Program
    {
        //Запечатанные, статические и австрактные классы. Урок по c# 5

        static void Main(string[] args)
        {
            //
            TransportShip transportShip = new TransportShip();
            TransportShip transportShip1 = new TransportShip();
            TransportShip.size = 50; // задание значения статическому полю

            transportShip.Distatnse = 1000;//переопределенное свойство
            Console.WriteLine(transportShip.Move(transportShip.Distatnse)); //переопределенный метод Move
            transportShip.InfoCoordinat(10, 20);//метод абстрактного класса

            //вывод значения статического поля для разных экземпляров
            Console.WriteLine("Размер первого транспортного корабля = " + transportShip.SizeShip());
            Console.WriteLine("Размер второго транспортного корабля = " + transportShip1.SizeShip());

            //Использование полностью статического класса
            BigShip.size = 100;
            Console.WriteLine(BigShip.SizeShip(BigShip.size));
            Console.ReadLine();
        }
    }
}
