using System;

namespace _49_ModificadoresDeAcesso
{
    //public, private, protected, internal
    //public: a *coisa* (membro, metodo, classe) pode ser acessada E alterada fora do escopo de definicao
    //private: a *coisa* SO pode ser acessada e alterada dentro do escopo de definicao
    //protected: a *coisa* SO pode ser acessada e alterada DENTRO do escopo da classe ou das classes filhas
    //internal: a *coisa* SO pode ser acessada e alterada DENTRO do ASSEMBLY em que ela foi definida
    class Player
    {
        protected string name;//private
        int level;

        public Player()
        {
            name = "NONAME";
            level = 1;
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
            Player p1 = new Player();
            Console.WriteLine($"Player1: {p1.name}, {p1.level}");
        }
    }
}
