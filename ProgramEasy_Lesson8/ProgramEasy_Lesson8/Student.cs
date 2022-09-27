using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson8
{
    /// <summary>
    /// Инвариантный интерфейс
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStudent<T>
    {
        /// <summary>
        /// Выходной параметр может быть обощенного типа
        /// </summary>
        /// <param name="animal">входной параметр может быть обощенного типа</param>
        /// <returns></returns>
        T Move(T animal); 
    }

    public class Student<T> : IStudent<T>
    {
        public T Move(T animal)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Ковариантный интерфейс
    /// Ключевое слово out позволяет приводить тип Т к его наследникам.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStudentOut<out T>
    {
        /// <summary>
        /// Выходной параметр может быть обобщенного типа Т
        /// </summary>
        /// <param name="distance">входной параметр не может быть обобщенного типа.</param>
        /// <returns></returns>
        T Move(int distance); 
    }

    public class StudentOut<T> : IStudentOut<T>
    {
        public T Move(int distance)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Контрвариантный интерфейс
    /// Ключевое слово in позволяет приводить наследный тип к типу Т.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStudentIn<in T>
    {
        /// <summary>
        /// Выходной параметр не может быть обобщенного типа Т
        /// </summary>
        /// <param name="distance">входной параметр может быть обобщенного типа.</param>
        /// <returns></returns>
        string Move(T animal);
    }

    public class StudentIn<T> : IStudentIn<T>
    {
        public string Move(T animal)
        {
            throw new NotImplementedException();
        }
    }

}
