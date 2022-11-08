using LabsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary
{
    public class Lab2 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            Console.WriteLine("введите число");
            int number = 0;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out number);
                if (res == true)
                {
                    if ((number >= 1) && (number <= 7))

                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("понедельник");
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
                        if (number == 1)
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
                break;
            }
            // Задание 2
            Console.WriteLine("введите число");
            int num = 10;
            if ((num % 3 == 0) && (num % 5 == 0))
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

            Console.WriteLine("Введите первое число");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак");
            string z1 = Console.ReadLine();
            if (z1 == "+")
            {
                Console.WriteLine(a1 + b1);
            }
            if (z1 == "-")
            {
                Console.WriteLine(a1 - b1);
            }
            if (z1 == "*")
            {
                Console.WriteLine(a1 * b1);
            }
            if (z1 == "/")
            {
                Console.WriteLine(a1 / b1);
            }

        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задание 2";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 2;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №2.  Тема: свич кейс и условия";
        }
    }
}