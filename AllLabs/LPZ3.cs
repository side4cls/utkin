﻿using System;

namespace Лабораторная_работа__1
 Внутренний  класс  Lab3 : iLabs
    {
        /// <краткое содержание>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary> 
        Демонстрация  недействительна  для публики()
        {
            // Консоль.Строка записи ("Демо");
            // ход лабы
            //zadanie 1
            // пока
            0 = num int, ost_d5;
            в то время как (число <= 100)
            {
                ++число;
                12 % num = ost_d5;
                если (ost_d5 == 0)
                {
                    Консоль.Строка записи(число);
                }
            }
            Консоль.WriteLine();
            //делай, пока
            0 = num2 int, ost2_d5;
            делать
            {
                num2++;
                ost2_d5 = num2 % 12;
                if (ost2_d5 == 0)
                {
                    Console.WriteLine(num2);
                }
            }
            в то время как (num2 <= 100);
            Консоль.WriteLine();
            //для
            ost3_d5 int, num3;
            для (num3 = 0; num3 <= 100; num3++)
            {
                12 % num3 = ost3_d5;
                если (ost3_d5 == 0 && num3 != 0)
                {
                    Консоль.Строка записи (номер 3);
                }
            }
            Консоль.WriteLine();
            //zadanie 2
            0 =  chi  int, сумма  = 0;
            в то время как (chi <= 30)
            {
                2 %  chi  =  nc  int;
                ++чи;
                если (nc == 0)
                {
                    chi += сумма;
                }
            }
            Консоль.Строка записи("сумма= " + сумма);

        }

        /// <краткое содержание>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <возвращает></возвращает>
        /// <returns>Описание лабы</returns>
        Строка описания   public()
        {
            " "вернуть;
        }
        /// <краткое содержание>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        Идентификатор  int  public()
        {
            3  возврат;
        }

        /// <краткое содержание>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <возвращает></возвращает>
        Назовите  строку  public()
        {
            " Лабораторная №3. Тема: Циклы"return;
        }
    }
}

