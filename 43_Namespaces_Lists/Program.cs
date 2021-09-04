using System;
using System.Collections.Generic;


//named spaces: espacos nomeados
//eles definem um escopo para um conjunto de classes e funcoes
class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
        //arrays 
        int[] myArray = new int[3];
        myArray[0] = 1;
        myArray[1] = 2;
        //funcionalidade para mudar de tamanho
        List<int> myList = new List<int>(3);
        myList.Add(-23);
        myList.Add(-23);
        myList.Add(-23);
        myList.Add(-23);
        myList.Add(-23);
        myList.Add(-23);
        myList.Add(-23);
        myList.RemoveAt(4);
        //comando -> funcoes -> classes -> namespaces
    }
}
