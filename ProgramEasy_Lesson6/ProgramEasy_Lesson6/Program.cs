using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Интерфейсы 6 урок C#

            //Использование классом TransportShip двух интерфейсов.
            TransportShip transportShip = new TransportShip();

            Console.WriteLine(transportShip.Coordinates(10, 20)); //Вызов метода класса
            Console.WriteLine(transportShip.Move(1000));
            Console.WriteLine(transportShip.Fight());
            IShip ship = transportShip; //приведение экземпляра класса к типу интерфейса
            Console.WriteLine(ship.Coordinates(20, 100)); //явный вызов интерфейса

            Console.WriteLine(transportShip.Destroy());
            IDestroy destroy = transportShip; //приведение экземпляра класса к типу интерфейса
            Console.WriteLine(destroy.Coordinates(50, 100)); //явный вызов интерфейса
            Console.ReadLine();

            //Использование встроенных интерфейсов
            Student student1 = new Student { Name = "Иван", Age = 25 };
            Student student2 = new Student { Name = "Олег", Age = 18 };

            Student[] students = new Student[] { student1, student2 };

            Console.WriteLine("Массив студентов {0} {1}", students[0].Name, students[1].Name);

            //Реализует сортировку с использованием интерфейса IComparable, при этом его не надо вызывать.
            Array.Sort(students);
            Console.WriteLine("Отсортированный массив студентов {0} {1}", students[0].Name, students[1].Name);

            Console.WriteLine(student1.Destroy()); //вызов метода интерфейса
            Console.WriteLine(student1.Coordinates(15,12));

            Console.ReadLine();
        }
    }
}
