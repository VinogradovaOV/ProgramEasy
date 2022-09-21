using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson4
{
    /// <summary>
    /// Базовый класс машин
    /// </summary>
    class BaseCar
    {
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="i">параметр</param>
        public BaseCar(int i)
        {
            Console.WriteLine("Базовый конструктор c  параметром {0}", i); //Вызывается первым
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


    }

    /// <summary>
    ///  Класс транспортных машин, наследник от базового класса
    /// </summary>
    class TransportCar : BaseCar
    {
        /// <summary>
        /// Конструктор без параметров, вызывает сначала базовый, куда надо обязательно передать параметр!!!
        /// </summary>
        public TransportCar():base(0)  
        {
            Console.WriteLine("Конструктор наследника без параметров");
        }

        /// <summary>
        /// Конструктор с параметром, вызывает сначала базовый, куда надо обязательно передать параметр!!!
        /// </summary>
        /// <param name="i"></param>
        public TransportCar(int i):base(1)
        {
            Console.WriteLine("Конструктор наследника c параметром {0}", i);
        }

        /// <summary>
        /// Конструктор с параметром, вызывает сначала базовый, куда передается параметр наследного класса!!!
        /// </summary>
        /// <param name="i"></param>
        public TransportCar(int i, int j) : base(i)
        {
            Console.WriteLine("Конструктор наследника c параметрами {0}, {1}", i, j);
            Console.WriteLine("В базовый конструктор передан первый параметр наследного конструктора");
        }
        public void Start()
        {

        }

    }
}
