using System;

namespace _3_Escopo
{
    class Program
    {
        static int variavelDaClasse;


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Teste();
            string mensagem = "Oi!";
            Console.WriteLine(variavelDaClasse);


            {
                //fala pro sistema operacional aloca um pedaco de memoria
                //para a variavel x
                int x = 3;//definicao de variavel

            }

            x = 2;
            //apagada
        }

        static void Teste()
        {
            int variavelDaFuncao = 2;
            Console.WriteLine(variavelDaClasse);
        }
    }
}
