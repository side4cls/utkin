using System;

namespace Лабороторная_работа__2
{
    class Program
    {
 // Задание 1
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int number = 0;
            while(true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out number);
                if (res == true)
                {
                    if ((number >= 1) && (number <= 7))

                    {
                        
                            switch(number)
                        {case 1:
                                Console.WriteLine("понедельник") ;
                            break;
                            case 2:
                                Console.WriteLine("вторник");
                            break;
                         case 3:
                                Console.WriteLine("среда");
                            break;
                         case 4:
                                Console.WriteLine("четверг");
                            break;
                         case 5:
                                Console.WriteLine("пятница");
                            break;
                         case 6:
                                Console.WriteLine("суббота");
                            break;
                         case 7:
                                Console.WriteLine("воскресенье");
                            break;
                        }
                        if(number == 1)
                        {
                            Console.WriteLine("понедельник");
                        }
                        if (number == 2)
                        {
                            Console.WriteLine("вторник");
                        }
                        if (number == 3)
                        {
                            Console.WriteLine("среда");
                        }
                        if (number == 4)
                        {
                            Console.WriteLine("четверг");
                        }
                        if (number == 5)
                        {
                            Console.WriteLine("пятница");
                        }
                        if (number == 6)
                        {
                            Console.WriteLine("суббота");
                        }
                        if (number == 7)
                        {
                            Console.WriteLine("воскресенье");
                        }
                    }
                    else Console.WriteLine("ошибка");

                }
                  else Console.WriteLine("ошибка");

// Задание 2
                 Console.WriteLine("введите число");
                 int num = 10;
                 if ((num %3 == 0) && (num %5 ==0))
                 {
                 Console.WriteLine("BuzzFizz");
                 }
                 else if (num % 3 == 0)
                 {
                 Console.WriteLine("Buzz");
                 }
                 else if (num % 5 == 0)
                 {
                 Console.WriteLine("Fizz");
                 }
                // Задание 3

                Console.ReadLine();

                Console.WriteLine("ок");
            }
           




        }
    }
}
