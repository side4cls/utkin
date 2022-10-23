using System;

namespace Лабораторная_работа__1
{
   внутренний  класс  Matrica
    {
        _value1 int private;
        _value2 int private;
        int private[,] _massiv;

        Общедоступная матрица  (int  value1, int  value2)
        {
            значение 1=  _value1;
            значение 2=  _value2;
            int  new = _massiv[значение1, значение2];
        }



        Случайная  пустота  public()
        {
            Случайное  новое = rnd  Random();
            for (int i = 0; i < _value1; i++)
            {
                for (int w = 0; w < _value2; w++)
                {
                    _massiv[i, w] = rnd.Next(0, 100);
                }
            }

        }
        Печать  недействительной  общедоступной()
        {
            for (int i = 0; i < _value1; i++)
            {
                Консоль.WriteLine();
                for (int w = 0; w < _value2; w++)
                {
                    Консоль.Написать(_massiv[i, w] + "\t");
                }
            }

        }
        Sum int public()
        {
            0  =  сумма  int;
            для (int  i = 0; i < _massiv.getLength(0); i++)
            {
                для (int  w = 0; w < _massiv.getLength(1); w++)
                {
                    _massiv += сумма[i, w];
                }
            }
            возврат суммы ;
        }
        ГлавДиаг  аннулирует  публичный доступ()
        {
            для (int  i = 0; i < _value1; i++)
            {
                for (int w = 0; w < _value2; w++)
                {
                    если (i == w)
                    {
                        Консоль.Строка записи(_massiv[i, i]);
                    }
                }
            }

        }

        PassivDiag  аннулирует  публичный доступ()
        {
            для (int  i = 0; i < _massiv.getLength(0); i++)
            {
                для (int  w = 0; w < _massiv.getLength(1); w++)
                {
                    если (i == w)
                    {
                        Консоль.Строка записи(_massiv[_massiv.getLength(0) - i - 1, i]);
                    }
                }
            }

        }
    }
}