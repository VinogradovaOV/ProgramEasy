using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditir.BL;

namespace ProgramEasy_Lesson7
{
     public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;

        private string _currentFilePath;

        public MainPresenter(IMainForm view, IFileManager manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService = messageService;

            _view.SetSymbolCount(0);

            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.Filesavelick += _view_Filesavelick;
        }

        /// <summary>
        /// Обработчик сохранения файла
        /// </summary>
        private void _view_Filesavelick(object sender, EventArgs e)
        {
            //На случай непредвиденных ошибок
            try
            {
                string content = _view.Content; //забираем контент из формы
                _manager.SaveContent(content, _currentFilePath); //сохраняем контент по текущему файловому пути
                _messageService.ShowMessage("Файл сохранен"); // пишем сообщение, что все хорошо

            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// Обработчик открытия файла
        /// </summary>
        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            //Прверка на случай непредвиденных ошибок
            try
            {
                string filePath = _view.FilePath; //получаем путь к файлу
                bool exist = _manager.IsExist(filePath); //прверяем наличие файла

                if (!exist)
                {
                    _messageService.ShowExclamation("Выбранный файл не существует"); //выводим ообщение пользователю
                    return;
                }

                _currentFilePath = filePath; //сохранение екущего пути к файлу

                string content = _manager.GetContent(filePath); // получение контента из файла
                int count = _manager.GetSymbolCount(content); // подсчет символов

                _view.Content = content; //вывод контента на форму
                _view.SetSymbolCount(count); //вывод колличествоа символов на форму
                
            }
            catch(Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
        
        /// <summary>
        /// Обработчик события изменения контента
        /// </summary>
        private void _view_ContentChanged(object sender, EventArgs e)
        {
            string content = _view.Content; //берем измененный контент
            int count = _manager.GetSymbolCount(content);//отправляем его в менеджер для подсчета колличества символов
            _view.SetSymbolCount(count);//выводим колл.символов на форму
        }
    }
}
