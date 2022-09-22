using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson6
{
    public class TransportShip : IShip, IDestroy
    {
        //Свой метод, не обязателен для реализации
        public string Coordinates(int x, int y)
        {
            return String.Format("Точка прибытия {0}, {1}", x, y);
        }

        //Реализация интерфейса IShip
        public string Fight()
        {
            return "Корабль не может вступить в бой";
        }

        public string Move(int distanse)
        {
            return "Дистанция до корабля = " + distanse;
        }

        //Явная реализация метода, совпадающего с названием метода из другого интерфейса.
        string IShip.Coordinates(int x, int y)
        {
            return String.Format("Координаты корабля {0}, {1}", x, y);
        }

        //Реализация интерфейса IDestroy
        public string Destroy()
        {
            return "Корабль уничтожен";
        }

        string IDestroy.Coordinates(int x, int y)
        {
            return String.Format("Уничтожен в точке {0}, {1}", x, y);
        }

    }

    /// <summary>
    /// Класс использует встроенный интерфейс для сортировки.
    /// </summary>
    public class Student : IDestroy, IComparable
    {

        public string Name;
        public int Age;


        //Реализация интерфейса IDestroy
        public string Destroy()
        {
            return "Студент отчислен";
        }

        public string Coordinates(int x, int y)
        {
            return String.Format("Номер общежития {0} {1}", x, y);
        }

        //Реализация встроенного интерфеса для сравнения двух объектов
        public int CompareTo(object obj)
        {
            Student student = (Student)obj;

            if (this.Age > student.Age) return 1;
            if (this.Age < student.Age) return -1;
            return 0;
        }
    }

}
