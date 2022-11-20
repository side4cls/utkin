using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    class Time: IValue
    {
        private List<string> _meassureList = new List<string>()
        {
            "Милисекунда",
            "Секунда",
            "Минута",
            "Час"
        };

        private double _value;
        private string _from;
        private string _to;
        public double GetConvertedValue(double value, string from, string to)
        {
            // проверка
            if (_value >= 0)
            {
                _value = value;
                _from = from;
                _to = to;
                ToSI();
                ToRequired();
                return _value;
            }
            else 
            {
                throw new NotImplementedException("Недопустимое значение");
            }
            
        }

        public List<string> GetMeassureList()
        {
            return _meassureList;
        }

        public void ToSI()
        {
            // преобразовать в СИ
            switch (_from)
            {
                case "Секунда":
                    break;
                case "Минута":
                    _value *= 60;
                    break;
                case "Час":
                    _value *= 3600;
                    break;
                case "Милисекунда":
                    _value /= 1000;
                    break;            
            }
        }

        public void ToRequired()
        {
            switch (_to)
            {
                case "Секунда":
                    break;
                case "Минута":
                    _value /= 60;
                    break;
                case "Час":
                    _value /= 3600;
                    break;
                case "Милисекунда":
                    _value *= 1000;
                    break;
            }
        }
    }
}
