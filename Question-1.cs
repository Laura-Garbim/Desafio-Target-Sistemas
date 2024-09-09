using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número:");
        int numero = int.Parse(Console.ReadLine());
        bool pertence = VerificarFibonacci(numero);
       
      if (pertence)
        {
            Console.WriteLine($"{numero} pertence a sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence a sequência de Fibonacci.");
        }
    }

    static bool VerificarFibonacci(int numero)
    {
        int a = 0, b = 1, c = 0;
        if (numero == a || numero == b)
        {
            return true;
        }
        while (c < numero)
        {
            c = a + b;
            a = b;
            b = c;
            if (c == numero)
            {
                return true;
            }
        }
        return false;
    }
}
