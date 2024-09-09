using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe uma palavra:");
        string input = Console.ReadLine();
        int contador = ContarOcorrenciasA(input);
        if (contador == 1)
        {
            Console.WriteLine("A letra a aparece uma vez.");
        }
        else if (contador > 1)
        {
            Console.WriteLine($"A letra a aparece {contador} vezes.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada.");
        }
    }

    static int ContarOcorrenciasA(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }
        return contador;
    }
}
