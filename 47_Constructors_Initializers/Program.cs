using System;

namespace _47_Constructors_Initializers
{
    class Player
    {
        public string name;
        public int level;

        //Inicializa variaveis da classe
        public Player()
        {
            name = "NONAME";
            level = 1;
            Console.WriteLine("Construindo o Player!");
        }

        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();//construir um objeto dessa classe
            Player p2 = new Player("Player2", 10);

            //Initializers
            Player p3 = new Player()
            {
                name = "Player3",
                level = 4
            };

            // Player p3 = new Player();
            // p3.name = "Player3";
            // p3.level = 4;

            string[] myStrings = new string[]
            {
                "223", "3232", "2323"
            };

            Console.WriteLine($"Player 1: {p1.name}, {p1.level}");
            Console.WriteLine($"Player 2: {p2.name}, {p2.level}");
            Console.ReadKey();
        }
    }
}
