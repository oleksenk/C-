using System;
namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Методы расширения");

            Console.WriteLine("\nРеверсивный int");
            int num = 123456789;
            Console.WriteLine(num);
            num.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nРеверсивная струна");
            string str = "Hello, World!";
            Console.WriteLine(str);
            str.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nРеверсивный двойной");
            double dNum = 123.567;
            Console.WriteLine(dNum);
            dNum.Reverse();
            Console.WriteLine();
            Console.WriteLine("\nРеверсирование массива int");
            int[] a = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            a.Reverse();

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nЗамена");
            int[] negArr = { 1, 2, -5, 10, -77, 0, 99 };

            negArr.ReplaceNegatives();

            for (int i = 0; i < negArr.Length; i++)
            {
                Console.Write(negArr[i] + " ");
            }
            Console.WriteLine();


        }
    }

    public static class IntExtensionMethods
    {
        public static void Reverse(this int num)
        {

            Console.Write(num % 10);
            while ((num /= 10) != 0)
            {

                Console.Write(num % 10);
            }
        }
        public static void Reverse(this string str)
        {
            char[] strArr = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
            }
        }
        public static void Reverse(this double dNum)
        {
            string[] splitedStr = dNum.ToString().Split(',');

            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
        }
        public static void Reverse(this int[] a)
        {
            int n = 0;
            int right = a.Length - 1;
            while (n < right)
            {
                int temp = a[right];
                a[right] = a[n];
                a[n] = temp;

                n++;
                right--;
            }
        }
        public static void ReplaceNegatives(this int[] nega)
        {

            int max = nega[0];

            for (int i = 1; i < nega.Length; i++)
            {
                if (nega[i] > max)
                {
                    max = nega[i];
                }
            }
            for (int i = 0; i < nega.Length; i++)
            {
                if (nega[i] < 0)
                {
                    nega[i] = max;
                }
            }

        }

    }
}
