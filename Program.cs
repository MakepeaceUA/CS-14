namespace ConsoleApp9

{
    internal class Program
    {

        static void Main(string[] args)
        {
            Film film1 = new Film("Дедпулл", "Marvel", "Боевик", 2, 2024);

            film1.DisplayInfo();
            film1.Dispose();

            Performance performance = new Performance("title", "studio", "genre",200,new List<string> {"Актёр 1", "Актёр 2", "Актёр 3"});
            performance.DisplayInfo();
            performance.Dispose();
        }
    }
}