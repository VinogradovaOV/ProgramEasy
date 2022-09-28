using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProgramEasy_Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Урок по C# 9. Множества.

            //Последовательность
            Progression progression = new Progression(10);

            Console.WriteLine("Реализация последовательности из 10 членов с шагом 3");
            foreach (int i in progression)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();

            //Коллекция
            StoreCollection collection = new StoreCollection("Test.txt");

            //collection.Add(128);
            Console.WriteLine("Реализация коллекции, вывод из файла, запись в файл числа 128");
            foreach (int i in collection)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            //Список, реализация

            List<int> list = new List<int>();
            list.Add(5);
            list.Add(6);
            list.Add(9);
            list.Add(3);
            Console.WriteLine("Реализация списка");
            Console.WriteLine("Вывод экземпяра списка под 2 номером");
            Console.WriteLine(list[2]);
            Console.ReadLine();

            list.Remove(9);
            Console.WriteLine("Вывод списка с удаленным экземпляром = 9");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Словарь, реализация.

            Dictionary<int, string> persons = new Dictionary<int, string>();

            Person person1 = new Person() { ID = 1, Name = "Олег" };
            Person person2 = new Person() { ID = 2, Name = "Игорь" };

            persons.Add(person1.ID, person1.Name);
            persons.Add(person2.ID, person2.Name);

            //Person searchPerson;
            string name;

            bool IsExist = persons.TryGetValue(2, out name);

            Console.WriteLine("Реализация словаря, поиск значения по ключу");
            if (IsExist)
                Console.WriteLine(name);
            Console.ReadLine();

        }

        public class Person
        {
            public int ID { get; set; }
            public string Name { get; set;}
        }

        /// <summary>
        /// Интерфейс последовательности
        /// </summary>
        public interface IEnumerable
        {
            /// <summary>
            /// Правило построения последовательности
            /// </summary>
            /// <returns>возвращает следующий элемент последовательности</returns>
            IEnumerator GetEnumerator();
        }
    }
}
