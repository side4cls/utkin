using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    public class Weight:IValue
    {
        private List<string> _meassureList = new List<string>()
        {
            "Грамм",
            "Килограмм",
            "Центнер",
            "Тонна"
            
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
                case "Грамм":
                    _value /= 1000;
                    break;
                case "Килограмм":
                    break;
                case "Центнер":
                    _value *= 100;
                    break;
                case "Тонна":
                    _value *= 1000;
                    break;
            }
        }

        public void ToRequired()
        {
            switch (_to)
            {
                case "Грамм":
                    _value *= 1000;
                    break;
                case "Килограмм":
                    break;
                case "Центнер":
                    _value /= 100;
                    break;
                case "Тонна":
                    _value /= 1000;
                    break;
            }
        }
    }
}
