using System;
using System.Drawing;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public abstract string Name { get; }
        public abstract string FigureColor { get; set; }
        public abstract int NumOfVertices { get; }
        public abstract double Square();
        public abstract double Perimeter();
        public static class RandomColor
        {
            private static Random rand = new Random();
            private static string[] colors = { "Red", "Green", "Blue", "Yellow", "Magenta" };
            public static int randomLeght() => rand.Next(1, 10);
            public static string randomColor() => colors[rand.Next(0, 4)];
        }
    }
    }
