using System;

namespace sr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 3\n");

            var cars = new Cars();
            bool exist = true;

            string color;
            int yearOfMade = 0;
            int price = 0;
            int enginePower = 0;

            byte amount = 0;
            string tempForInput;

            Console.WriteLine("Магази барыги Равшана");
            Console.WriteLine("Хотите ли вы вибрать автомобиль по характеристикам?");
            Console.WriteLine("{Yes(Да, хочу), No(Нет, не хочу покажите мне все автомобили которие у вас есть!!)}");
            Console.Write("Введите y или n: ");
            tempForInput = Console.ReadLine();

            if (tempForInput == "y")
            {
                while (exist)
                {
                    amount = 0;
                    color = null;
                    tempForInput = null;

                    Console.WriteLine();
                    Console.WriteLine("Вы можете вибрать себе автомобиль за такими характеристиками");
                    Console.Write("{Цвет(");
                    Console.Write("На английском__");
                    Console.Write("), Год производства, Цена и Мощьность двигателя} \n");
                    Console.Write("Если ви хотите пропустить какую-то характеристику введите \n\n");

                    Console.Write("Введите цвет нужный авто: ");
                    color = Console.ReadLine();
                    if (color == "-")
                        amount++;

                    Console.Write("Введите нужный год выпуска: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else yearOfMade = Convert.ToInt32(tempForInput);

                    Console.Write("Введите нужный цену: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else price = Convert.ToInt32(tempForInput);

                    Console.Write("Введите нужный мощьность двигателя: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else enginePower = Convert.ToInt32(tempForInput);

                    cars.findCar(amount, color, yearOfMade, price, enginePower);

                    Console.WriteLine("\nМне не нравлятся ети машини хочу вибрать еще раз! ");
                    Console.WriteLine("{Yes, No(Виход из программи)}");
                    Console.Write("Введите y или n: ");
                    tempForInput = Console.ReadLine();
                    exist = tempForInput == "y" ? true : false;
                }
            }
            else
            {
                cars.showInfoAboutCars();
                Console.WriteLine();
                exist = false;
            }

        }
    }
}