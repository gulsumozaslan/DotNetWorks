using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8
{
    public interface IStudent
    {
        public string Name { get; set; }
        public int StudentNumber { get; set; }

        //Öğrencinin dersleri ve notları
        Dictionary<string,int> Grades { get; }

        //Metotlar
        void AddGrade(string course, int grade);
        void PrintTranscript();
    }
}
