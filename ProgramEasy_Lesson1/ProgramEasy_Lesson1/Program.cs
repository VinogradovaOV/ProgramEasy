using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Изучение типов данных в C#

            //Стурктура - тип данных по значению.
            StudentStruct studentStr = new StudentStruct(); // new вызывает конструктор класса или структуры.
            studentStr._age = 5;
            Console.WriteLine("Начальное значение перременной структуры = " + studentStr._age);
            Calculate(studentStr);
            Console.WriteLine("Текущее значение переменной структуры = " + studentStr._age);
            Console.WriteLine("Текущее значение не изменилось, т.к. в метод была отправлена копия структуры.");
            Console.ReadLine();

            //Класс - ссылочный тип данных
            StudentClass studentCl = new StudentClass();
            studentCl._age = 5;
            Console.WriteLine("Начальное значение переменной класса = " + studentStr._age);
            Calculate(studentCl);
            Console.WriteLine("Текущее значение переменной класса = " + studentCl._age);
            Console.WriteLine("Текущее значение изменилось, т.к. в метод была отправлена ссылка на класс.");
            Console.ReadLine();
        }

        /// <summary>
        /// Показательный метод при работе с переменными структуры
        /// </summary>
        /// <param name="student"></param>
        private static void Calculate(StudentStruct student)
        {
            student._age += 1;
            Console.WriteLine("Измененное значение переменной структуры = " + student._age);
        }

        /// <summary>
        /// Показательный метод при работе с переменными класса.
        /// </summary>
        /// <param name="student"></param>
        private static void Calculate(StudentClass student)
        {
            student._age += 1;
            Console.WriteLine("Измененное значение переменной класса = " + student._age);
        }
    }

}
