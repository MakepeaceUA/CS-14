using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Film : IDisposable
    {
        private string title;
        private string studio;
        private string genre;
        private int duration; 
        private int year;
        private bool disposed = false;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Studio
        {
            get { return studio; }
            set { studio = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value > 0)
                    duration = value;
                else
                    Console.WriteLine("Error.");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1800 && value <= DateTime.Now.Year)
                    year = value;
                else
                    Console.WriteLine("Error.");
            }
        }
        public Film(string ti, string st, string ge, int du, int ye)
        {
            Title = ti;
            Studio = st;
            Genre = ge;
            Duration = du;
            Year = ye;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Киностудия: {Studio}, Жанр: {Genre}, Длительность: {Duration} час(а,ов), Год выпуска: {Year}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Освобождение управляемых ресурсов.");
                }
                Console.WriteLine("Освобождение неуправляемых ресурсов.");
                disposed = true;
            }
        }
        ~Film()
        {
            Dispose(false);
            Console.WriteLine($"Фильм '{Title}' удалён из памяти.");
        }
    }
}
