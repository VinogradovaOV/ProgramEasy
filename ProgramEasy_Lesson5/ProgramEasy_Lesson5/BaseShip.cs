using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson5
{
    /// <summary>
    /// Абстрактный класс кораблей, не имеет экземпляров, выступает в качестве родителя.
    /// </summary>
    public abstract class BaseShip
    {
        public abstract int Distatnse { get; set; } // Для абстрактных членов типа необходима реализация в наследнике
        public abstract string Move(int distanse);

        public void InfoCoordinat(int x, int y)
        {
            Console.WriteLine("Координаты корабля {0},{1}", x, y);
        }
    }

    /// <summary>
    /// Наследник абстрактного класса, запечатан - не может быть родителем.
    /// </summary>
    public sealed class TransportShip: BaseShip
    {
        static TransportShip()
        {
            Console.WriteLine("Статический конструктор класса, вызывается самым первым, один раз за всю программу.");

        }

        public static int size; //статическое поле одно для всех экземпляров типа

        public override int Distatnse { get; set; }

        public override string Move(int distanse)
        {
            return "Дистанция до корабля = " + distanse;
        }

        public string SizeShip()
        {
            return "" + size;
        }
    }

    /// <summary>
    /// Статический класс, не реализует наследование, не имеет экземпляров.
    /// может содержать в себе только статические члены
    /// </summary>
    public static class BigShip
    {
        public static int size;

        public static string SizeShip(int s)
        {
            return "Размер Большого корабля = " + s;
        }
    }
}
