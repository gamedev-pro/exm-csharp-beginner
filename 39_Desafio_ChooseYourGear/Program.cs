using System;

namespace _8_Desafio_ChooseYourGear
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLineAndWait("Um apocalipse zumbi acabou de acontecer do nada na sua cidade");
            PrintLineAndWait("Voce comeca a correr e pega tudo que ve pela frente...");

            //Items iniciais do player
            string[] inventoryItems = new string[3];

            //1 - Com ifs
            Console.WriteLine();
            PrintLineAndWait("Voce se depara com uma PANELA e um TRAVESSEIRO.");
            int index1 = ReadNumberInput("Digite 1 para pegar a PANELA e 2 para pegar o TRAVESSEIRO");
            if (index1 == 1)
            {
                inventoryItems[0] = "PANELA";
            }
            else if (index1 == 2)
            {
                inventoryItems[0] = "TRAVESSEIRO";
            }
            else
            {
                Console.WriteLine("Erro de input!");
            }

            //2 - Com arrays
            string[] choices2 = new string[] { "ARMA", "GAME BOY" };
            Console.WriteLine();
            PrintLineAndWait("Voce se depara com uma ARMA e um GAME BOY.");
            int index2 = ReadNumberInput("Digite 1 para pegar a ARMA e 2 para pegar o GAME BOY");
            index2 -= 1;
            if (index2 >= 0 && index2 < choices2.Length)
            {
                inventoryItems[1] = choices2[index2];
            }
            else
            {
                Console.WriteLine("Erro de INPUT!");
            }

            //3 - Com funcoes
            Console.WriteLine();
            string[] choices3 = new string[] { "CAMISA", "BARRA DE CHOCOLATE" };
            string itemChoice = ReadItemOption(choices3);
            if (itemChoice != "")
            {
                inventoryItems[2] = itemChoice;
            }
            else
            {
                Console.WriteLine("Erro de INPUT!");
            }

            /////////
            Console.WriteLine($"Suas escolhas foram: {inventoryItems[0]}, {inventoryItems[1]} e {inventoryItems[2]}");

            Console.ReadKey();
        }

        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static int ReadNumberInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                return -1;
            }
        }

        static string ReadItemOption(string[] choices)
        {
            PrintLineAndWait($"Voce se depara com um {choices[0]} e um {choices[1]}");
            int index = ReadNumberInput($"Digite 1 para pegar o {choices[0]} e 2 para pegar o {choices[1]}");
            index -= 1;
            if (index >= 0 && index < choices.Length)
            {
                return choices[index];
            }
            return "";
        }
    }
}
