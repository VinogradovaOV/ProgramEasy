using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson8
{
    public class Animal
    {
        public void Move()
        { }
    }

    public class Cat: Animal
    {
    }

    public class Dog: Animal
    {
    }

    /// <summary>
    /// Класс с обобщением Т, но с ограничением Т - либо animal, либо его наследники
    /// </summary>
    /// <typeparam name="T">обобщенный параметр с ограничением</typeparam>
    public class Zoo<T>
        where T : Animal, new()
    {
        /// <summary>
        /// Метод принимает обобщенный параметр
        /// </summary>
        /// <param name="animal"></param>
        public void MoveAnimal(T animal)
        {
            //Может оратиться к методу Move, принадлежащему класу animal и его потомкам
            animal.Move();
        }

        public T GetAnimal()
        {
            //Может создать новый экземпляр, так как явно указали в классе эту возможность. 
            //А значит классы animal и потомки должны содержать конструктор по умолчанию и не быть абстрактными классами.
            T animal = new T();
            return animal;
        }
    }

}
