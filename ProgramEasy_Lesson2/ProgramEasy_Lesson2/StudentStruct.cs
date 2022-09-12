using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson2
{
    struct StudentStruct
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
        public int Mass { get; set; }

        //Конструктор типа без параметров в структуре явно создавать нельзя!
        //public StudentStruct()
        //{
        //    _age = 0;
        //}

        /// <summary>
        /// Конструктор типа с параметром int
        /// В конструкторе структуры надо обязательно инициализировать все переменные!!!
        /// </summary>
        /// <param name="age">Возраст студента</param>
        public StudentStruct(int age)
        {
            this = new StudentStruct(); //Вызывем конструктор по умолчанию, он всем переменным присваивает 0(по умолчанию).
            _age = age;
        }
    }
}
