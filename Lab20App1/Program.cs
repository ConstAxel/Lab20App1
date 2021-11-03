using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20App1
{
    class Program
    {
        delegate double CalcCircle(double r);
        static void Main(string[] args)
        {
            //1.В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:

            //-метод получает входным параметром переменную типа double;

            //-метод возвращает значение типа double, которое является результатом вычисления.




            //Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

            //-длину окружности по формуле D = 2 * π * R;

            //-площадь круга по формуле S = π * R²;

            //-объем шара.Формула V = 4 / 3 * π * R³.

            //Методы должны быть объявлены как статические.
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            CalcCircle calcCircle1 = Circle.Length;
            double length = calcCircle1(r);
            Console.WriteLine($"Длина окружности = {length:f2}");

            CalcCircle calcCircle2 = Circle.Square;
            double square = calcCircle2(r);
            Console.WriteLine($"Площадь круга = {square:f2}");

            CalcCircle calcCircle3 = Circle.Volume;
            double volume = calcCircle3(r);
            Console.WriteLine($"Объем шара = {volume:f2}");

            Console.ReadKey();
        }
        static public class Circle
        {
            static public double Length(double r)
            {
                return 2 * Math.PI * r;
            }
            static public double Square(double r)
            {
                return Math.PI * r * r;
            }
            static public double Volume(double r)
            {
                return 4 * Math.PI * Math.Pow(r, 3) / 3;
            }
        }
    }
}
