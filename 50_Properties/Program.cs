using System;

namespace _50_Properties
{
    //public, private, protected, internal
    /*
    1 - private por default
    2 - usar getters e/ou setters para expor acesso aos membros da classe
    3 - ter poucos metodos publicos
    */

    //Propriedades (Properties)
    //Eh uma coisa que parece uma variavel da classe, mas eh um getter e/ou um setter
    class Player
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        private int level;
        public int Level => level;

        //auto property
        public int Money { get; private set; }

        public Player(string name, int level, int money)
        {
            this.name = name;
            this.level = level;
            Money = money;
        }

        public void GiveXP(int xpAmount)
        {
            //dar experiencia ao player
            //se passou de level -> level++
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("P1", 1, 100);
            Console.WriteLine($"Player1: {p1.Name}, {p1.Level}, {p1.Money}");
            p1.Name = "NewName";
            Console.WriteLine($"Player1: {p1.Name}");

            Console.ReadKey();
        }
    }
}
