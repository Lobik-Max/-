using System;

namespace Занятия
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ты робот?");
            string x = Console.ReadLine();
            if (x == "Да" | x == "Конечно") 
            {
                Console.WriteLine("Привет, робот!");
            }
            else
            if(x == "Нет") 
            {
                Console.WriteLine("Поздравляю, ты прошёл проверку!");
            }
            else 
            {
                Console.WriteLine("Прости, я тебя не понимаю.");
            }*/



            /*string x = Console.ReadLine();
            switch (x)
            {
                case "Ноль":
                    Console.WriteLine("Один");
                    break;
                case "Один":
                    Console.WriteLine("Два");
                    break;
                case "Два":
                    Console.WriteLine("Три");
                    break;
                case "Три":
                    Console.WriteLine("Четыре");
                    break;
                case "Четыре":
                    Console.WriteLine("Пять");
                    break;
                case "Пять":
                    Console.WriteLine("Шесть");
                    break;
                case "Шесть":
                    Console.WriteLine("Семь");
                    break;
                case "Семь":
                    Console.WriteLine("Восемь");
                    break;
                case "Восемь":
                    Console.WriteLine("Девять");
                    break;
                case "Девять":
                    Console.WriteLine("Десять");
                    break;
                case "0":
                    Console.WriteLine("Один");
                    break;
                case "1":
                    Console.WriteLine("Два");
                    break;
                case "2":
                    Console.WriteLine("Три");
                    break;
                case "3":
                    Console.WriteLine("Четыре");
                    break;
                case "4":
                    Console.WriteLine("Пять");
                    break;
                case "5":
                    Console.WriteLine("Шесть");
                    break;
                case "6":
                    Console.WriteLine("Семь");
                    break;
                case "7":
                    Console.WriteLine("Восемь");
                    break;
                case "8":
                    Console.WriteLine("Девять");
                    break;
                case "9":
                    Console.WriteLine("Десять");
                    break;
                default:
                    Console.WriteLine("Слишком большое число! Я не знаю ответ");
                    break;
            */


            /*try
            {
                decimal x = Convert.ToDecimal(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("-");
                }
                else
                if (x > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }*/

            /*int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Это число чётное");
            }
            else
            {
                Console.WriteLine("Это не число чётное");
            }*/

            /*int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            if(x > y && x > z)
            {
                Console.WriteLine(x);
            }
            if(y > x && y > z)
            {
                Console.WriteLine(y);
            }
            if(z > x && z > y)
            {
                Console.WriteLine(z);
            }*/

            /*int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y & x < z || x < y & x > z)
            {
                Console.WriteLine(x);
            }
            if (y > x & y < z || y < x & y > z)
            {
                Console.WriteLine(y);
            }
            if (z > x & z < y || z < x & z > y)
            {
                Console.WriteLine(z);
            }*/

            /*decimal x = Convert.ToDecimal(Console.ReadLine());
            string y = Console.ReadLine();
            decimal z = Convert.ToDecimal(Console.ReadLine());
            switch (y)
            {
                case "+":
                    Console.WriteLine(x + z);
                    break;
                case "-":
                    Console.WriteLine(x - z);
                    break;
                case "*":
                    Console.WriteLine(x * z);
                    break;
                case "/":
                    Console.WriteLine(x / z);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }*/



            /*string x = Console.ReadLine();
            int y = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<y; i++)
            {
                Console.WriteLine(x);
            }*/



            /*int x = 0;
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                x = x + 1;
                Console.WriteLine(x);
            }*/


            /*int x = 0;
            for (int i = 0; i < 5; i++)
            {
                x += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(x);*/

            /*int y = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                y = y + 1;
                Console.WriteLine($"{x}  *  {y}  =  {x * y}");
            }*/



            /*int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= y; i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else

                Console.WriteLine(i);
            }*/



            for (int i = 0; i < 10 ; i++)
            {
                for (int j = 1; j < 10 ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }














        }
    }
}
