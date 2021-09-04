using System;

namespace _36_Enums
{
    class Program
    {

        //enum (enumeracao)
        enum DifficultyLevel//Definindo um TIPO 
        {
            Beginner,
            Normal,
            Expert,

            GodMode
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo! Escolha seu nivel de dificuldade");
            Console.WriteLine($"As opcoes sao: {DifficultyLevel.Beginner}, {DifficultyLevel.Normal} e {DifficultyLevel.Expert}");
            string difficultyLevelString = Console.ReadLine();

            DifficultyLevel difficultyLevel;
            bool success = Enum.TryParse<DifficultyLevel>(difficultyLevelString, out difficultyLevel);

            if (success)
            {
                //forca do inimigo seja 1x no iniciante, 2x no normal e 5x no expert
                int enemyPower = 20;
                bool firstTimeUser = true;

                switch (difficultyLevel)
                {
                    case DifficultyLevel.Beginner:
                        Console.WriteLine("Voce escolheu o nivel Iniciante!");
                        Console.WriteLine($"Forca dos Inimigos: {enemyPower}");
                        break;
                    case DifficultyLevel.Normal:
                        Console.WriteLine("Voce escolheu o nivel Normal!");
                        enemyPower *= 2;
                        Console.WriteLine($"Forca dos Inimigos: {enemyPower}");
                        break;
                    case DifficultyLevel.Expert:
                        if (firstTimeUser == true)
                        {
                            Console.WriteLine("Voce nao pode escolher o Expert no seu primeiro playthrough!");
                        }
                        else
                        {
                            Console.WriteLine("Voce escolheu o nivel Expert!");
                            enemyPower *= 5;
                            Console.WriteLine($"Forca dos Inimigos: {enemyPower}");
                        }
                        break;
                    default:
                        Console.WriteLine($"Valor inexperado: {difficultyLevel}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Valor inesperado! {difficultyLevelString}");
            }

            Console.ReadKey();
        }
    }
}
