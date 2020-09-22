using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Час вільного падіння обчислюється за формулою (t=sqrt((2h)/g))*/
            double t, h, g = 9.8;
            Console.WriteLine("Введіть висоту");
            h = double.Parse(Console.ReadLine());
            t = (Math.Sqrt((2 * h) / g));
            Console.WriteLine("Час падіння =" + t);
        }
    }
}
