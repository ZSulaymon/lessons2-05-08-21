using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 8;
            int b = 8;*/
            /* int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());*/
            Console.WriteLine("Введите А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            string text = "";
            if (a != b && b > a)
            {
                a = b;
                text = "B больше A";

            }
            else if (a > b)
            {
                b = a;
                text = "A больше B";
            }
            else if (a == b)
            {
                a = b = 0;
                text = "A и B равны";
            }
            Console.WriteLine($"{text}");
            Console.WriteLine($"a = {a} ,  b={b} ");
        }
    }
}
