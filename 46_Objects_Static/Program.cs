using System;

namespace _46_Objects_Static
{
    //Template ou um Bluerprint ou um Modelo para criar OBJETOS da classe Player
    class Player
    {
        public string name = "NONAME";
        public int level = 1;

        public static int initialLevel = 10;

        public void Test()
        {

            Console.WriteLine($"{name}");
        }

        public static void MyStaticFunction()
        {
            Console.WriteLine($"{initialLevel}");
        }
    }

    class Program
    {
        void MinhaFuncao(int x, int y)
        {
            //funcionalidade da funcao
        }
        static void Main(string[] args)
        {
            Player p1 = new Player();//Objeto da classe Player (do tipo Player)
            Player p2 = new Player();

            Program myProgram = new Program();
            myProgram.MinhaFuncao(0, 0);

            Console.WriteLine($"Initial Level: {Player.initialLevel}");

            Console.WriteLine($"Nome do Player 1 {p1.name}, Nome do Player 2 {p2.name}");
            p1.name = "Eu sou o P1";
            Console.WriteLine($"Nome do Player 1 {p1.name}, Nome do Player 2 {p2.name}");

            Console.ReadKey();
        }
    }
}
