using System;

namespace _45_Classes
{
    class Player
    {
        public string name = "NONAME";
        public int level = 1;

        public void Test()
        {
            Console.WriteLine($"{name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Player p1 = new Player();
            Console.WriteLine($"Nome do Player {p1.name}, Level do Player {p1.level}");
            p1.level = 10;
            Console.WriteLine($"Level do player: {p1.level}");

            Console.ReadKey();
        }
    }
}
