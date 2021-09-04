using System;

namespace _4_Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.ReadLine();
        }

        static void MathOperations()
        {
            int a = 2;//Assignment
            int b = 3;
            Console.WriteLine(a + b);//Adicao -> 5
            Console.WriteLine(a - b);//Subtracao -> -1
            Console.WriteLine(a * b);//Multipliacao -> 6
            Console.WriteLine(b % a);//Resto da divisao de a / b

            //cast -> converte um tipo para outro tipo
            float resultadoDaDivisao = (float)a / b;//0.6667
            Console.WriteLine(resultadoDaDivisao);//Divisao -> 0

            //Operacoes + Assignments
            a = a + 2;
            a += 2;

            //A ordem de prioridade de operacoes
            //E como controlar essa ordem
            //Multiplicacao e Divisao tem prioridade
            a = 2;
            b = 3;
            int sum1 = a + b * a;//8
            int sum2 = (a + b) * a;//
            Console.Write("Sum1: ");
            Console.WriteLine(sum1);

            Console.Write("Sum2: ");
            Console.WriteLine(sum2);
        }

        static void StringOperations()
        {
            //Operacoes com Strings
            string a = "Primeira Mensagem";
            string b = "Segunda mensagem";
            // Console.WriteLine(a + b);

            //Insira seu nome:
            //pega o input
            //Seu nome eh: {nome}
            string nome = "Teste";
            Console.WriteLine("Seu nome eh: " + a + ", " + b + ", " + nome);
            Console.WriteLine($"Seu nome eh:{a}, {b}, {nome}");
        }

        static void BooleanOperations()
        {
            //Operacoes Booleanas
            //retornam True ou False

            //Comparacao entre numeros
            // >, <, >=, <=
            // ==, !=
            int a = 2;
            int b = 3;
            Console.WriteLine($"a > b ?: {a > b}");
            Console.WriteLine($"a < b ?: {a < b}");

            Console.WriteLine("2 >= 2 ? " + (2 >= 2));
            Console.WriteLine("0 <= 2 ? " + (0 <= 2));

            Console.WriteLine($"3 == 1 ?: {3 == 1}");
            Console.WriteLine($"3 != 3 ?: {3 != 3}");

            //Operacoes Booleanas puras
            // OR, AND e NOT
            //OR (||) -> True se QUALQUER valor for verdadeiro
            //AND (&&) -> True APENAS SE TODOS os valores forem verdadeiros
            //NOT (!) -> Nega o valor (True -> False, False -> True)

            bool bool1 = true;
            bool bool2 = false;

            Console.WriteLine("bool1 || bool2 ? " + (bool1 || bool2));//true
            Console.WriteLine("bool1 && bool2 ? " + (bool1 && bool2));//false
            Console.WriteLine("!bool1 ? " + (!bool1));//false
            Console.WriteLine("!!bool1 ? " + (!!bool1));//true

        }
    }
}
