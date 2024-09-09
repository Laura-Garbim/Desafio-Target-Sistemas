using System;

class Program
{
    static void Main()
    {
        // a)
        int[] a = { 1, 3, 5, 7 };
        Console.WriteLine("Próximo número da sequência a: " + (a[a.Length - 1] + 2));

        // b)
        int[] b = { 2, 4, 8, 16, 32, 64 };
        Console.WriteLine("Próximo número da sequência b: " + (b[b.Length - 1] * 2));

        // c)
        int[] c = { 0, 1, 4, 9, 16, 25, 36 };
        int proximoQuadrado = (int)Math.Pow(Math.Sqrt(c[c.Length - 1]) + 1, 2);
        Console.WriteLine("Próximo número da sequência c: " + proximoQuadrado);

        // d)
        int[] d = { 4, 16, 36, 64 };
        int proximoQuadradoPar = (int)Math.Pow(Math.Sqrt(d[d.Length - 1]) + 2, 2);
        Console.WriteLine("Próximo número da sequência d: " + proximoQuadradoPar);

        // e)
        int[] e = { 1, 1, 2, 3, 5, 8 };
        int proximoFibonacci = e[e.Length - 1] + e[e.Length - 2];
        Console.WriteLine("Próximo número da sequência e: " + proximoFibonacci);

        // f)
        int[] f = { 2, 10, 12, 16, 17, 18, 19 };
        int proximoF = f[f.Length - 1] + 1;
        Console.WriteLine("Próximo número da sequência f: " + proximoF);
    }
}
