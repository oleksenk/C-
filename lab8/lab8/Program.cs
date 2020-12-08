using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garag myGarage = new Garag();
            Console.WriteLine(" Вы в гараже ");
            int choice;
            do
            {
                Console.WriteLine();
                if (myGarage.myCars.Count == 0)
                {
                    Console.WriteLine("1 - добавить новую машину");
                    Console.WriteLine("0 - закрыть гараж)");
                }
                else
                {
                    Console.WriteLine("1 - добавить новую машину");
                    Console.WriteLine("2 - показать все мои машины");
                    Console.WriteLine("3 - удалить машину ");
                    Console.WriteLine("4 - найти машины по одной её характеристике");
                    Console.WriteLine("0 - закрыть гараж");
                }
                Console.Write("Выберите вариант: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Введите правильный вариант: ");
                }
                switch (choice)
                {
                    case 1:
                        myGarage.AddNewCar();
                        Console.WriteLine("Автомобиль добавлен!");
                        Console.WriteLine(myGarage.myCars.Count);
                        break;
                    case 2:
                        myGarage.DisplayCars();
                        break;
                    case 3:
                        myGarage.RemoveCar();
                        break;
                    case 4:
                        Console.WriteLine("По какой характеристики мы будем искать?");
                        char characteristic;
                        Console.WriteLine("n - Имя");
                        Console.WriteLine("c - Цвет");
                        Console.WriteLine("s - Скорость");
                        Console.WriteLine("y - год выпуска");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myGarage.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                        Console.WriteLine("Гараж закрывается");
                        return;
                    default:
                        Console.WriteLine("Вы выбрали не то");
                        break;
                }
            } while (choice != 0);
        }
    }
}