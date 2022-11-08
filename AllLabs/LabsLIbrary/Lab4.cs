using LabsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary
{
    public class Lab4 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            //zadanie 1
            int[] mass = new int[13];

            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
                Console.Write(mass[i] + "\t");
            }
            Console.WriteLine();
            //zadanie 2
            string str = "awd 23 f 4 rg3 3";
            string[] strraz = str.Split(' ');
            foreach (string el in strraz)
            {
                Console.WriteLine(el);
            }
            //zadanie 3
            Console.Write("ВВедите размерновсть массива n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("введите элемент массива mas[{0}]=", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Сортировака массива
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int tmp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = tmp;
                    }
                }
            }
            //вывод массива на экран
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("элемент массива mas[{0}]={1}", i, mas[i]);
            }
            System.Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задание 4";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 4;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №4. Тема: сортировка";
        }
    }
}