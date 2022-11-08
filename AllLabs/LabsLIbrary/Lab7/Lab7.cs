using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LabsInterface;


namespace LabsLibrary.Lab7
{
    class Lab7 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы

            Group PKS20 = new Group();
            PKS20.Add(new Student("Глеб", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
            PKS20.Add(new Student("Артем", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
            PKS20.Add(new Student("Максим", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
            PKS20.Add(new Student("Владислав", 17, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));

            Group BD = new Group();
            BD.Add(new Student("Мария", 19, "женский", "BD", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Егор", 20, "мужской", "BD", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Петр", 21, "мужской", "BD", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Валерия", 20, "женский", "BD", "ВКУиНТ", "Банковское дело"));
            Group GD = new Group();

            GD.Add(new Student("Анжелика", 20, "женский", "GD", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Александр", 21, "мужской", "GD", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Евгений", 22, "мужской", "GD", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Сергей", 20, "мужской", "GD", "ВКУиНТ", "Гостиничное дело"));

            List<Group> GroupList = new List<Group>();
            GroupList.Add(PKS20);
            GroupList.Add(GD);
            GroupList.Add(BD);
            Console.WriteLine("Группа: ПКС-20");
            PKS20.PrintGroup();
            Console.WriteLine("Группа: ГД-18");
            GD.PrintGroup();
            Console.WriteLine("Группа: БД-19");
            BD.PrintGroup();

            Console.WriteLine();
            Console.ReadKey();

        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задание 7";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 7;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №7. Сериализация";
        }
    }
}