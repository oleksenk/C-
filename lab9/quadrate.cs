using System;

namespace ConsoleApp1
{
    class Quadrate : Shape, IDraw
    {
        private double sideA;
        private string name;
        public double Side
        {
            get { return sideA; }
            set
            {
                if (value <= 0)
                {
                    sideA = 1;
                }
                else
                {
                    sideA = value;
                }
            }
        }
        public override int NumOfVertices { get { return 4; } }
        public override string Name { get { return name; } }
        public override string FigureColor { get; set; }
        public Quadrate(string name, string color, double side)
        {
            this.name = name;
            FigureColor = color;
            Side = side;
        }
        public Quadrate(string name, double side)
        {
            this.name = name;
            Side = side;
            FigureColor = RandomColor.randomColor();
        }
        public Quadrate(string name)
        {
            this.name = name;
            FigureColor = RandomColor.randomColor();
            Random r = new Random();
            Side = r.Next(100);
        }
        public override double Square()
        {
            return Side * Side;
        }
        public override double Perimeter()
        {
            return 2 * (Side + Side);
        }
        public void Draw()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Имя: {0} \nЦвет: {1} \nСторона: {2} \nКвадрат: {3} \nПериметр: {4}",
                Name, FigureColor, Side, Square(), Perimeter());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Это действительно Квадрат !!!");
            Console.WriteLine("___________________________________");
        }
    }
}