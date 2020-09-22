using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 0;
            while (n < 4)
            {
                Console.WriteLine("Введіть розмір графіка, але не менше 4!");
                n = int.Parse(Console.ReadLine());
                if (n < 4)
                {
                    Console.WriteLine("Ви ввели неправельно, введіть щераз!");
                }
            }
            int[] a;
            int k;
            k = 0;
            a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("n[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; ++i)
            {
                Console.Write(a[i] + " ");
            }
            for (int i = 1; i < n - 1; ++i)
            {
                if (a[i] > a[i + 1] || a[i] > a[i - 1])
                {
                    k = k + 1;
                }
            }
            k--;
            Console.WriteLine("кількість проміжків монотонносці = " + k);
        }
    }
}
