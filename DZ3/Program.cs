using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            //double operand1 = 10;
            //double operand2 = 0;
            Console.WriteLine("Введите первое значение");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ариф знак");
            string sign = Console.ReadLine();
            Console.WriteLine("Введите второе значение");
            double operand2 = Convert.ToDouble(Console.ReadLine());
                      
                        switch (sign)
                        {
                            case "+":
                                    Console.WriteLine($"Сумма = {operand1 + operand2}");
                               break;
                           
                            case "-":
                                    Console.WriteLine($"Сумма = {operand1 - operand2}");
                                break;
                            case "*":
                                    Console.WriteLine($"Сумма = {operand1 * operand2}");
                                break;
                            case "/":
                                    if (operand2 == 0 || operand1 ==0)
                                    {
                                        Console.WriteLine("на 0 нельзя делить");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Сумма = {operand1 / operand2}");
                                    }
                                break;
                            default:
                                    Console.WriteLine("Ошибка, Вы вели не правильный арифмитическый знак!");
                                break;
                        }
                                    
  
        }
    }
}
