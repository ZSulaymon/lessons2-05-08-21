using System;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            //double operand1 = 10;
            //double operand2 = 0;
            //Console.WriteLine("Введите первое значение");
            //double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Число");
            int sign = Convert.ToInt32(Console.ReadLine());
            //int a = 1;
         /*   int[] a = { 0, 1,2,3,4,5,6,7,8,9,10,11,12,13,14 };
            int[] b = { 0, 1,2,3,4,5,6,7,8,9,10,11,12,13,14 };
            int[] c = { 0, 1,2,3,4,5,6,7,20,21,22,23,24,13,14 };
  
            */
         int a = 14;
         int b = 35;
         int c = 50;
         int d = 100;

            if (sign < a)
            {
                Console.WriteLine("Вы попали в промежуток 0-14");
            }
            else if (sign < b)
            {
                Console.WriteLine("Вы попали в промежуток 15-35");
            }
            else if (sign < c)
            {
                Console.WriteLine("Вы попали в промежуток 36-50");
            }
            else if (sign < d)
            {
                Console.WriteLine("Вы попали в промежуток 50-100");
            }
            else
            {
                Console.WriteLine("Вы не попали в промежуток");
            }
            //Console.WriteLine("Введите второе значение");
            //double operand2 = Convert.ToDouble(Console.ReadLine());

            /*switch (sign)
            {
                case :
                    Console.WriteLine($"Сумма = {}");
                    break;
*//*
                case "-":
                    Console.WriteLine($"Сумма = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"Сумма = {operand1 * operand2}");
                    break;
                case "/":
                    if (operand2 == 0 || operand1 == 0)
                    {
                        Console.WriteLine("на 0 нельзя делить");
                    }
                    else
                    {
                        Console.WriteLine($"Сумма = {operand1 / operand2}");
                    }
                    break;*/
            /*              default:
                              Console.WriteLine("Ошибка, Вы вели не правильный арифмитическый знак!");
                              break;
                      }
          */
        }
    }
}
