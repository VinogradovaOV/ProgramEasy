using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson4
{
    /// <summary>
    /// Базовый класс корблей
    /// </summary>
    class BaseShip
    {
        public BaseShip()
        {
            Console.WriteLine("Базовый конструктор без параметров"); //Вызывается первым
        }

        private int _counter; // поле видимое только в базовом классе, приватное.

        protected int _speed; // поле видимое и в наследных классах, но приватное для остальных

        // Метод, видимый и в наследных классах и извне.
        public string Move(int distance)
        {
            _counter++;

            string result = string.Format("Пройдено километров {0}", distance);

            return result;
        }

        public virtual void Start()
        {
            Console.WriteLine("Базовый переопределяемый метод");
        }


    }

    /// <summary>
    ///  Класс транспортных кораблей, наследник от базового класса
    /// </summary>
    class TransportShip: BaseShip
    {
        public TransportShip():base() //неявно вызывает базовый конструктор, написание :base() можно опустить.
        {
            Console.WriteLine("Конструктор наследника без параметров");
        }

        public override void Start()
        {

            Console.WriteLine("Сперва вызовем базовый метод Start");
            base.Start();
            Console.WriteLine("Метод переопределен в наследнике");
        }

    }
}
