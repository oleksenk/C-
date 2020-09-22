using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введіть розмір квадратної матреці");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("m[" + i + "]n[" + j + "] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] b = new int[n, n];
            int k = 1;
            int z;
            /*Дана квадратна матриця порядку M. Замінити нулями елементи матриці,
            що лежать 1) нижче 2) вище 3) головної; 4) побічної діагоналі.*/
            while (k < 5)
            {
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        b[i, j] = a[i, j];
                    }
                }
                if (k == 1)
                {
                    Console.WriteLine("1)");
                    for (int i = 1; i < n; ++i)
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            if (i > j)
                            {
                                b[i, j] = 0;
                            }
                        }
                    }
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            Console.Write(b[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                if (k == 2)
                {
                    Console.WriteLine("2)");
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = 1; j < n; ++j)
                        {
                            if (j > i)
                            {
                                b[i, j] = 0;
                            }
                        }
                    }
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            Console.Write(b[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                if (k == 3)
                {
                    Console.WriteLine("3)");
                    for (int i = 0; i < n; ++i)
                    {
                        b[i, i] = 0;
                    }
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            Console.Write(b[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                if (k == 4)
                {
                    Console.WriteLine("4)");
                    z = n - 1;
                    int x = 0;
                    while (z >= 0)
                    {
                        while (x < n)
                        {
                            b[z, x] = 0;
                            x++;
                            z--;
                        }
                    }
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            Console.Write(b[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                k++;
            }
        }
    }
}
