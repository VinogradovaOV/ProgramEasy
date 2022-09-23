﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditir.BL;

namespace ProgramEasy_Lesson7
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessageService messageService = new MessageService();
            FileManager manager = new FileManager();

            MainPresenter presenter = new MainPresenter(form, manager, messageService);

            Application.Run(form);
        }
    }
}
