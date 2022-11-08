using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary.Lab7
{
        [DataContract]
        public class Group
        {
            [DataMember]
            List<Student> _groupList = new List<Student>();
            public void Add(Student student)
            {
                _groupList.Add(student);
            }
            public void PrintGroup()
            {
                for (int i = 0; i < _groupList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ") " + _groupList[i].Name + " " + _groupList[i]);
                    Console.Write("Возраст: " + _groupList[i].Age + "\t");
                    Console.Write("Пол: " + _groupList[i].Gender + "\t");
                    Console.Write("ВУЗ: " + _groupList[i] + "\t");
                    Console.Write("Специальность: " + _groupList[i] + "\n");
                }
            }
        }
}