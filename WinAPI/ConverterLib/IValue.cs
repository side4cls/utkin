using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    interface IValue
    {
        #region Методы для API
        //получение на стороне API конвертируемой величины
        double GetConvertedValue(double value, string from, string to);        
        // получение на стороне API списка единиц измерения
        List<string> GetMeassureList();
        void ToSI();
        void ToRequired();
       

        #endregion
    }
}
