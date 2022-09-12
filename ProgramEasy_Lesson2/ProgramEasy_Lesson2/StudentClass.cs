using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson2
{
    class StudentClass
    {
        /// <summary>
        /// Поле типа, приватное, используется только внутри типа.
        /// Значения задаются с помощью методов типа или свойств типа.
        /// </summary>
        private int _age;

        /// <summary>
        /// Публичное свойство типа, задает и возвращает значение переменной _age
        /// Можно добавить различные проверки внутрь свойства, например, что возраст не может быть меньше 0.
        /// Сокращенная запись тривиального свойства public int Age{get; set;}
        /// Так же можно отдельно задавать модификаторы доступа для get и set свойства
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //Конструктор типа без параметров
        //Если сами задаем конструктор типа класса, то конструктор по умолчанию не создается!
        public StudentClass()
        {
            _age = 0;
        }

        //В данном случае конструктор без параметров вызывает конструктор с параметрами и передает ему значение 0.
        //Это позволяют всю логику писать в одном конструкторе.
        //public StudentClass(): this(0)
        //{ }

        /// <summary>
        /// Конструктор типа с параметром int
        /// </summary>
        /// <param name="age">Возраст студента</param>
        public StudentClass(int age)
        {
            _age = age;
        }

        // Метод типа. Void - не возвращает значения. Публичный, доступен извне типа.
        public void Grow()
        {
            _age++;
        }

        /// <summary>
        /// Методы с одинакрвым именем, но с разными параметрами называются перегруженными.
        /// </summary>
        /// <param name="years">возраст студента</param>
        public void Grow(int years)
        {
            _age+=years;
        }

        // Метод типа. Возвращает значение int.
        public int GetAge() 
        {
            String message = "Возвращает возраст"; // локальная переменная метода, видна только внутри метода.
            return _age;
        }
    }

}
