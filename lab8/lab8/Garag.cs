using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Garag
    {
        public List<Car> myCars = new List<Car>();

        public void AddNewCar()
        {
            string name;
            string color;
            int speed;
            int year;

            Console.Write("\nВведите название автомобиля: ");
            name = Console.ReadLine();

            Console.Write("Введите цвет автомобиля: ");
            color = Console.ReadLine();

            Console.Write("Введите максимальною скорость автомобиля: ");
            while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
            {
                Console.Write("Введите правильное значение максимальнои скорости, пожалуйста: ");
            }

            Console.Write("Укажите год выпуска автомобиля: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year > 2020 || year < 1885)
            {
                Console.Write("Пожалуйста, введите правильный год выпуска: ");
            }

            Car newCar = new Car(name, color, speed, year);

            myCars.Add(newCar);
        }

        public void DisplayCars()
        {
            Console.WriteLine("\nМой  гараж!");
            int i = 1;
            foreach (Car c in myCars)
            {
                DisplayInfoAboutCar(c);
                i++;
            }
        }

        public void RemoveCar()
        {
            int position;
            Console.Write("Выберите позицию для удаления: ");
            while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > myCars.Count)
            {
                Console.Write("На этой позиции нет машин. Позиция: ");
            }
            myCars.RemoveAt(position - 1);
            Console.WriteLine("Автомобиль на позиции {0} удален", position);
        }

        public void SearchByOneCharacteristic(char characteristic)
        {
            int i = 0;
            switch (characteristic)
            {
                case 'n':
                    Console.Write("Как называеться ваш автомобиль: ");
                    string name = Console.ReadLine();

                    foreach (Car c in myCars)
                    {
                        if (c.Name == name)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Извините, совпадений не найдено.");
                    i = 0;
                    break;

                case 'c':
                    Console.Write("Какого цвет ваш автомобиль: ");
                    string color = Console.ReadLine();
                    foreach (Car c in myCars)
                    {
                        if (c.Color == color)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Извините, совпадений не найдено.");
                    i = 0;
                    break;

                case 's':
                    Console.Write("Какая максимальная скорость вашого автомобиля: ");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    foreach (Car c in myCars)
                    {
                        if (c.Speed == speed)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Извините, совпадений не найдено.");
                    i = 0;
                    break;

                case 'y':
                    Console.Write("Какого года ваш автомобиль: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    foreach (Car c in myCars)
                    {
                        if (c.YearofIssue == year)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Извините, совпадений не найдено.");
                    i = 0;
                    break;

                default:
                    Console.WriteLine("Извините, такой характеристики нет.");
                    break;
            }

        }

        public void DisplayInfoAboutCar(Car car)
        {
            Console.WriteLine("\nИмя  : {0}\nЦвет  : {1}\nМаксимальная скорость  : {2}\nГод  : {3}", car.Name, car.Color, car.Speed, car.YearofIssue);
        }
    }
}