using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson9
{
    public class StoreCollection : ICollection<int>
    {
        private readonly string _filePath;

        /// <summary>
        /// Конструктор коллекции
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        public StoreCollection(string filePath)
        {
            _filePath = filePath;
        }

        private string[] GetNumbers()
        {
            string line = File.ReadAllText(_filePath);
            string[] numbers = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int item)
        {
            string[] numbers = GetNumbers();
            if (numbers.Length == 0)
                File.WriteAllText(_filePath, item.ToString());
            else
                File.AppendAllText(_filePath, "," + item.ToString());
        }

        public void Clear()
        {
            File.WriteAllText(_filePath, "");
        }

        public bool Contains(int item)
        {
            string[] numbers = GetNumbers();

            foreach (string number in numbers)
            {
                if (Int32.Parse(number) == item)
                    return true;
            }

            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                yield return Int32.Parse(number);
            }
        }

        public bool Remove(int item)
        {
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return GetEnumerator();
        }
    }
}
