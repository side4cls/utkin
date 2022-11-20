using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    class Length:IValue
    {
        private List<string> _meassureList = new List<string>()
        {
            "Милиметр",
            "Сантиметр",
            "Дециметр",
            "Метр",
            "Километр"
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
                case "Метр":
                    break;
                case "Милиметр":
                    _value /= 1000;
                    break;
                case "Сантиметр":
                    _value /= 100;
                    break;
                case "Дециметр":
                    _value /= 10;
                    break;
                case "Километр":
                    _value *= 1000;
                    break;
            }
        }

        public void ToRequired()
        {
            // преобразовать в СИ
            switch (_to)
            {
                case "Метр":
                    break;
                case "Милиметр":
                    _value *= 1000;
                    break;
                case "Сантиметр":
                    _value *= 100;
                    break;
                case "Дециметр":
                    _value *= 10;
                    break;
                case "Километр":
                    _value /= 1000;
                    break;
            }
        }
    }
}
