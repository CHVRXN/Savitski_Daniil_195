using System;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            try
            {
                Console.Write("Первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Второе число: ");
                b = Convert.ToDouble(Console.ReadLine());
                if (b == 0) throw new DivideByZeroException();
                Console.WriteLine("Результат: " + (result = a / b));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0 невозможно");
            }

            catch (FormatException)
            {
                Console.WriteLine("Неверное значение");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка операции");
            }

            Console.WriteLine();
            Console.WriteLine("Размер типа данных int = " + sizeof(int) + " bytes");
            Console.WriteLine("Размер типа данных float = " + sizeof(float) + " bytes");
            Console.ReadKey();
        }
    }
}