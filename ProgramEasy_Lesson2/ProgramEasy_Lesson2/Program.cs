using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Состав типа C#

            //Демонстрация работы с методами и свойствами класса
            Console.WriteLine("Присвоение переменной класса значения через метод:");
            StudentClass studentClass = new StudentClass();
            studentClass.Grow(15);
            Console.WriteLine("Возраст студента  = " + studentClass.Age);
            Console.ReadLine();

            ////Демонстрация работы с конструкторм структуры
            Console.WriteLine("Присвоение переменной структуры значения через конструктор:");
            StudentStruct studentStruct = new StudentStruct(15);
            
            Console.WriteLine("Возраст студента  = " + studentStruct.Age);
            Console.WriteLine("Масса студента ставится по умолчанию  = " + studentStruct.Mass);
            Console.ReadLine();


        }
    }
}
