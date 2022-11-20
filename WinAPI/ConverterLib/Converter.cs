using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    public class Converter
    {
        private List<string> _physicValues = new List<string>()
        {
        "Длина",
        "Скорость",
        "Время",
        "Объем",
        "Вес"
        };

        public List<string> GetPhysicValuesList()
        {
            return _physicValues;
        }

        public List<string> GetMeassureList(string physicValue)
        { 
            switch (physicValue)
            {
                case "Длина":
                    _value = new Length();
                    break;
                case "Время":
                    _value = new Time();
                    break;
                case "Вес":
                    _value = new Weight();
                    break;
            }
            return _value.GetMeassureList();
        }

        private IValue _value;
        public double GetConvertedValue(string physicValue, double value, string from, string to)
        {
                switch (physicValue)
                {
                    case "Длина":
                        _value = new Length();
                        break;
                    case "Время":
                        _value = new Time();
                        break;
                    case "Вес":
                        _value = new Weight();
                        break;
                }
                return _value.GetConvertedValue(value, from, to);
            

        }
      
    }
}
