using LabsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary
{
    public class Lab3 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            //zadanie 1
            //while
            int num = 0, ost_d5;
            while (num <= 100)
            {
                num++;
                ost_d5 = num % 12;
                if (ost_d5 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine();
            //do while
            int num2 = 0, ost2_d5;
            do
            {
                num2++;
                ost2_d5 = num2 % 12;
                if (ost2_d5 == 0)
                {
                    Console.WriteLine(num2);
                }
            }
            while (num2 <= 100);
            Console.WriteLine();
            //for
            int ost3_d5, num3;
            for (num3 = 0; num3 <= 100; num3++)
            {
                ost3_d5 = num3 % 12;
                if (ost3_d5 == 0 && num3 != 0)
                {
                    Console.WriteLine(num3);
                }
            }
            Console.WriteLine();
            //zadanie 2
            int chi = 0, summa = 0;
            while (chi < 30)
            {
                int nc = chi % 2;
                chi++;
                if (nc == 0)
                {
                    summa += chi;
                }
            }
            Console.WriteLine("summa= " + summa);

        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задании 3";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 3;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №3. Тема: Циклы";
        }
    }
}