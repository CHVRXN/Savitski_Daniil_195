using System;

namespace Calculator
{
    public class CalculatorChecker
    {
        public static double ValidateCalculator(double n1, double n2, string op)
        {
            if (op == "+")
            {
                return (n1 + n2);
            }

            if (op == "-")
            {
                return (n1 - n2);

            }
            if (op == "*")
            {
                return (n1 * n2);

            }
            if (op == "/")
            {
                if (n2 == 0.0D)
                {
                    throw new DivideByZeroException();
                }
                return (n1 / n2);
                try
                {
                    if (n2 == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя");

                        return 1;
                    }
                    else
                        Console.WriteLine("Результат :" + " " + n1 / n2);

                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return 0;
        }
        static public void Main()
        {
            double a = 0;
            double b = 0;

            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            double result = CalculatorChecker.ValidateCalculator(a, b, "*");
            Console.WriteLine("Результат: " + result);
        }
    }
}
