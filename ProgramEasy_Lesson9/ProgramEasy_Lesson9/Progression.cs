using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson9
{
    /// <summary>
    /// Класс прогрессии с шагом 3
    /// </summary>
    public class Progression : IEnumerable<int>
    {
        /// <summary>
        /// Колличество элементов в прогрессии
        /// </summary>
        private readonly int _itemCount;

        /// <summary>
        /// Конструктор прогрессии
        /// </summary>
        /// <param name="itemCount">колличество элементов</param>
        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }

        /// <summary>
        /// Обобщенный метод
        /// </summary>
        /// <returns></returns>
        public IEnumerator<int> GetEnumerator()
        {
            //Использование временного итератора с помощью ключевого слова yield
            int current = 1;
            for (int i = 0; i < _itemCount - 1; i++)
            {
                if (i == 0) yield return 1;
                current += 3;
                yield return current;
            }

            //явный вызов итератора
            //return new ProgressionIterator(_itemCount);
        }

        /// <summary>
        /// необобщенный метод, вызывает обобщенный.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    /// <summary>
    /// Описывает правило изменения членов прогрессии 
    /// </summary>
    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        private int _position; //текущий номер последовательности
        private int _current; //текущее значение последовательности

        public ProgressionIterator(int itemCount)
        {
            //Начальные значения последовательности
            _itemCount = itemCount;
            _current = 1;
            _position = 0;
        }

        /// <summary>
        /// Возвращает содержимое _current
        /// </summary>
        public int Current => _current;

        object IEnumerator.Current => Current; //необобщенная форма

        /// <summary>
        /// Очитстка неуправляемых ресурсов, например БД
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Осуществляет движение по последовательности и вычисление текущего элемента Current
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_position > 0)
                _current += 3;
            if (_position < _itemCount)
            {
                _position++;
                return true; //мы можем двигаться дальше по последовательности
            }

            return false;
        }

        /// <summary>
        /// Сброс состояния на начальное
        /// </summary>
        public void Reset()
        {
            _current = 1;
            _position = 0;
        }
    }
}
