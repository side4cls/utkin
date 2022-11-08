using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary.Lab5
{
    class Matrix
    {
        private int _a;
        private int _b;
        private int[,] _mass;

        public Matrix(int stroki, int stolbi)
        {
            _a = stroki;
            _b = stolbi;
            _mass = new int[stroki, stolbi];
        }

        public void Random()
        {
            Random rnd = new Random();
            for (int i = 0; i < _a; i++)
            {
                for (int j = 0; j < _b; j++)
                {
                    _mass[i, j] = rnd.Next(0, 100);

                }
            }

        }
        public void Print()
        {
            for (int i = 0; i < _a; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < _b; j++)
                {
                    Console.Write(_mass[i, j] + "\t");
                }
            }

        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _mass.GetLength(0); i++)
            {
                for (int j = 0; j < _mass.GetLength(1); j++)
                {
                    sum += _mass[i, j];
                }
            }
            return sum;
        }
        public void GlavDiag()
        {
            for (int i = 0; i < _a; i++)
            {
                for (int j = 0; j < _b; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(_mass[i, i]);
                    }
                }
            }

        }

        public void PassivDiag()
        {
            for (int i = 0; i < _mass.GetLength(0); i++)
            {
                for (int j = 0; j < _mass.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(_mass[i, _mass.GetLength(0) - i - 1]);
                    }
                }
            }

        }
    }
}