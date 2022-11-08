using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabsLibrary.Lab7
{
    [DataContract]
    public class Student : Person
    {
        private string v1;
        private int v2;
        private string v3;
        private string v4;
        private string v5;
        private string v6;

        public Student(string v1, int v2, string v3, string v4, string v5, string v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        [DataMember]
        public string Group { get; set; }
        [DataMember]
        public string Institution { get; set; }
        [DataMember]
        public string Specialization { get; set; }
    }
}