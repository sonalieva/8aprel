using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public Student()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public string Fullname { get; set; }
        public Dictionary<string, int> Exams { get; set; } = new Dictionary<string, int>();
        public void AddExam(string exName, int point)
        {
            Exams.Add(exName, point);
        }
        public int GetExamResult(string exName)
        {
            foreach (var item in Exams)
            {
                if (item.Key == exName)
                {
                    return item.Value;
                }
            }
            return 0;
        }
        public int GetExamAvg()
        {
            int sum = 0;
            int count = 0;
            int avg = 0;
            foreach (var item in Exams.Values)
            {
                count++;
                sum += item;
               
            }
            if (count > 0)
            {
                avg = sum / count;
            }
            return avg;
            
        }
    }
}
