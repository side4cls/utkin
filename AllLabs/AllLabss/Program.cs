using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using LabsInterface;

namespace AllLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadILabsList();
            Methods.LabsInfo(_labs);
            bool running = true;
            while (running)   // запускаем бесконечный цикл
            {
                Console.Write("Введите номер лабораторной: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "clear":
                        Methods.Clear();
                        break;
                    case "info":
                        Methods.LabsInfo(_labs);
                        break;
                    case "help":
                        Methods.Help();
                        break;
                    case "exit":
                        running = false;
                        break;
                    default:
                        {
                            Methods.Demo(_labs, command);
                        }
                        break;
                }
            }
        }
        private static List<ILabs> _labs = new List<ILabs>();
        /// <summary>
        /// Метод получения списка лабараторных из dll библиотеки классов
        /// </summary>
        private static void LoadILabsList()
        {
            Assembly asm = Assembly.LoadFrom("LabsLib.dll"); //создание сборки из библиотеки классов
            Type[] types1 = asm.GetTypes();
            Type[] types = types1; //выгрузка классов в массив
            foreach (Type type in types)  //перебираем классы и интерфейсы
            {
                if ((type.IsInterface == false) && (type.IsAbstract == false)) //не добавляем абстрактные классы и интерфейсы
                {
                    foreach (var method in type.GetMethods()) //перебираем методы класса
                    {
                        if (method.ToString().Contains("Demo")) //если среди методов класса содержится Demo
                        {
                            ILabs labs = (ILabs)Activator.CreateInstance(type);
                            _labs.Add(labs); //подгружаем этот класс в список лабараторных
                        }
                    }
                }
            }
        }
        public class Methods
        {
            /// <summary>
            /// Метод запускает Demo по введенному ID
            /// </summary>
            /// <param name="labs"></param>
            /// <param name="id"></param>
            public static void Demo(List<ILabs> labs, string id)
            {
                try
                {
                    int ID = Convert.ToInt32(id);
                    foreach (ILabs lab in labs)
                    {
                        if (ID == lab.Id())
                        {
                            lab.Demo();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Неверная команда. Попробуйте еще раз.");
                }
            }

            /// <summary>
            /// Метод выводит информацию обо всех доступных лабораторных
            /// </summary>
            /// <param name="labs"></param>
            public static void LabsInfo(List<ILabs> labs)
            {
                foreach (ILabs lab in labs)
                {
                    Console.WriteLine(lab.Name());
                    Console.WriteLine(lab.Description());
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Метод очищает экран
            /// </summary>
            public static void Clear()
            {
                Console.Clear();
            }

            /// <summary>
            /// Метод выводит все доступные команды
            /// </summary>
            public static void Help()
            {
                string[] commands =
                {
            "<ID> - запуск демонстрации лабораторной по номеру",
            "<exit> - выход",
            "<help> - список доступных команд",
            "<clear> - очистка экрана",
            "<info> - вывод информации о всех лабораторных"
        };

                foreach (string command in commands)
                {
                    Console.WriteLine(command);
                }
            }
        }
    }
}