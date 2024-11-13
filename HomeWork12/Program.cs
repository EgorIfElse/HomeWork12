using System.ComponentModel.Design;

namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());
            double l = Circle.GetLong(r);
            double s = Circle.GetSquare(r);
            Console.WriteLine($"Длина окружности = {l},\nПлощадь круга равна {s}");
            Console.WriteLine("Введите координаты точки Х и У для проверки ее пересечения");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (Circle.GetContains(r, x, y))
            {
                Console.WriteLine("Точка находится в круге");
            }

            else
            {
                if (Circle.GetContainsFor(r, x, y))
                {
                    Console.WriteLine("Точка находится на круге");
                }
                else
                {
                    Console.WriteLine("Точка находится за пределами круга");
                }

            }

                
            
            
                
        }

            
    }
}
