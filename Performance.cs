using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Performance : IDisposable
    {
        public string Title { get; set; }
        public string Theater { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public List<string> Actors { get; set; }

        private bool disposed = false;

        public Performance(string t, string th, string g, int d, List<string> a)
        {
            Title = t;
            Theater = th;
            Genre = g;
            Duration = d;
            Actors = a;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Театр: {Theater}, Жанр: {Genre}, Длительность: {Duration} часов, Актёры: ");
            foreach (var actor in Actors)
            {
                Console.WriteLine($" - {actor}");
            }
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
        ~Performance()
        {
            Dispose(false);
            Console.WriteLine($"Выступление '{Title}' удалёно из памяти.");
        }
    }
}
