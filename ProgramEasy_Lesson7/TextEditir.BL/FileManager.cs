using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TextEditir.BL
{
    /// <summary>
    /// Интерфейс работы с файлами для общения с Presenter
    /// </summary>
    public interface IFileManager
    {
        bool IsExist(string filePath);
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        int GetSymbolCount(string content);
    }

    /// <summary>
    /// Класс, реализующий интерфейс работы с файлами.
    /// </summary>
    public class FileManager:IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251); //кодировка по умолчанию

        /// <summary>
        /// Проверка наличия файла
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <returns></returns>
        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        /// <summary>
        /// открыть текстовый файл
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <returns></returns>
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _defaultEncoding);
        }

        /// <summary>
        /// Открыть текстовый файл
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <param name="encoding">кодировка</param>
        /// <returns></returns>
        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }

        /// <summary>
        /// сохранить текстовый файл
        /// </summary>
        /// <param name="content">текст</param>
        /// <param name="filePath">путь к файлу</param>
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _defaultEncoding);
        }

        /// <summary>
        /// сохранить текстовый файл
        /// </summary>
        /// <param name="content">текст</param>
        /// <param name="filePath">путь к файлу</param>
        /// <param name="encoding">кодировка</param>
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }

        /// <summary>
        /// колличество символов в тексте
        /// </summary>
        /// <param name="content">текст</param>
        /// <returns></returns>
        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;
        }

    }
}
