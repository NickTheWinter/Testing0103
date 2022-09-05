using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing0103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInterface();
            Console.ReadLine();
        }
        public static void PrintInterface()
        {
            Console.WriteLine("Выберите номер примера");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Написать программу, которая запрашивает ввод с клавиатуры двух" +
                        "положительных вещественных чисел и вычисляет логарифм первого числа по " +
                        "основанию второго");
                    FirstTask();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Написать программу, которая вычисляет периметр и площадь " +
                        "прямоугольника по введенным пользователем координатам его диагонали");
                    SecondTask();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Напишите программу, которая проверяет, дает ли введенное с клавиатуры " +
                        "число одинаковый остаток при делении на 3 и на 4");
                    ThirdTask();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Напишите программу, которая печатает в столбик все цифры введенного n - значного " +
                        "(n от 1 до 10) числа в порядке убывания разрядов");
                    FourthTask();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Посчитайте значение следующего выражения при условии, что " +
                        "пользователь вводит с клавиатуры значения х");
                    FifthTask();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Выведите на экран последовательность n первых чисел Фибоначчи (с " +
                        "указанием их индекса), имеющих нечетные индексы.Количество чисел n " +
                        "пользователь вводит с клавиатуры");
                    SixthTask();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Пользователь вводит число n с клавиатуры. Используя оператор цикла " +
                        "необходимо вычислить сумму первых n членов следующей последовательности");
                    SeventhTask();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Пользователь вводит три действительных (вещественных) числа. Нужно " +
                        "определить, является ли сумма каких - либо двух из этих чисел отрицательной");
                    EighthTask();
                    break;
                default:
                    PrintInterface();
                    break;
            }                         
        }
        public static void FirstTask()
        {
            Console.WriteLine("Введите первое число");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double second = Convert.ToDouble(Console.ReadLine());
            double log = Math.Log(first, second);
            Console.WriteLine($"Логарифм числа {first} по основанию {second} равен: {log}");
        }
        public static void SecondTask()
        {
            Console.WriteLine("Введите координаты первой точки диагонали");
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки диагонали");
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            double perimetr = 2 * (Math.Abs(xA - xB) + Math.Abs(yA - yB));
            double square = Math.Abs(xA - xB) * Math.Abs(yA - yB);
            Console.WriteLine($"Периметр прямоугольника равен: {perimetr}\n" +
                              $"Площадь прямоугольника равна: {square}");

        }
        public static void ThirdTask()
        {
            Console.WriteLine("Введите число");
            double number = Convert.ToDouble(Console.ReadLine());
            double remainderOfThree = number % 3;
            double remainderOfFour = number % 4;
            bool boolean = remainderOfFour == remainderOfThree ? true : false;
            if (boolean)
            {
                Console.WriteLine("Остаток от деления от трёх равен остатку от деления от четырех");
            }

        }
        public static void FourthTask()
        {
            Console.WriteLine("Введите n-число (n от 1 до 10)");
            string number = Console.ReadLine();
            if(number.ToString().Count() <= 10)
            {
                char[] reverse = number.ToArray();
                Array.Reverse(reverse);
                foreach (char c in reverse)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                FourthTask();
            }
            
        }
        public static void FifthTask()
        {
            Console.WriteLine("Введите значение x");
            double x = double.Parse(Console.ReadLine());
            double tmp = Math.Log10(Math.Cos(x)) / Math.Log10(1 + x * x);
            Console.WriteLine("Значение выражения равно: {0}", tmp);

        }
        public static void SixthTask()
        {

        }
        public static void SeventhTask()
        {

            Console.WriteLine("Введите количество n членов последовательности");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

            }
        }
        public static void EighthTask()
        {
            Console.WriteLine("Введите 3 вещественных числа");
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            double firstSum = first + second;
            double secondSum = second + third;
            double thirdSum = third + first;

            if(firstSum < 0 || secondSum < 0 || thirdSum < 0)
                Console.WriteLine("Сумма каких либо двух из этих чисел отрицательна");
            else
                Console.WriteLine("Суммы не отрицательны");
        }
    }
}
