using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramEasy_Lesson7
{
    /// <summary>
    /// Свойства к которым имеет доступ Presenter
    /// </summary>
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler Filesavelick;
        event EventHandler ContentChanged;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            //события, которые используются в дальнейшем в Presenter
            butOpenFile.Click += ButOpenFile_Click;
            butSaveFile.Click += ButSaveFile_Click;
            fldContent.TextChanged += FldContent_TextChanged;

            //Местные события для выбора файла и для задания размера шрифта.
            butSelectFile.Click += ButSelectFile_Click;
            numFont.ValueChanged += NumFont_ValueChanged;
        }

        #region Обработка местных событий
        /// <summary>
        /// Задание размера шрифта
        /// </summary>
        private void NumFont_ValueChanged(object sender, EventArgs e)
        {
            fldContent.Font = new Font("Calibri", (float)numFont.Value); 
        }

        /// <summary>
        /// Открытие окна диалога для выбора файла
        /// </summary>
        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fldFilePath.Text = dialog.FileName;
                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }
        #endregion

        #region Проброс событий формы в интерфейс, с которым общается Presrnter
        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }

        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            if (Filesavelick != null) Filesavelick(this, EventArgs.Empty);
        }

        private void FldContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }
        #endregion

        #region реализация интерфейса IMainForm
        public string FilePath
        {
            get { return fldFilePath.Text; }
        }

        public string Content
        {
            get { return fldContent.Text; }
            set { fldContent.Text = value; }
        }

        public void SetSymbolCount(int count)
        {
            SLblSymbolCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler Filesavelick;
        public event EventHandler ContentChanged;
        #endregion
    }
}
